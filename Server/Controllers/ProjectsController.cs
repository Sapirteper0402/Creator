using FinalProject_SapirTeper_OfirEinhoren.Server.Data;
using FinalProject_SapirTeper_OfirEinhoren.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_SapirTeper_OfirEinhoren.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProjectsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            List<Project> ProjectsList = await _context.Projects.Include(p => p.ProjectBlocks).ToListAsync();
            return Ok(ProjectsList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {
            Project Project = await _context.Projects.FirstOrDefaultAsync(p => p.ID == id);
            if (Project != null)
            {
                return Ok(Project);
            }
            else
            {
                return BadRequest("no such Project...");
            }
        }

        //הוספה
        [HttpPost("Insert")]
        public async Task<IActionResult> AddProjec(Project project)
        {
            if (project != null)
            {
                _context.Projects.Add(project);
                project.ColorDesign = "light";
                project.CreationDate = DateTime.Now;
                project.UpdateDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return Ok(project);
            }
            else
            {
                return BadRequest("Projec was not send");
            }
        }


        //מחיקה
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            Project Project = await _context.Projects.FirstOrDefaultAsync(p => p.ID == id);
            if (Project != null)
            {
                _context.Projects.Remove(Project);
                await _context.SaveChangesAsync();
                return Ok(true);
            }
            else
            {
                return BadRequest("no such Project...");
            }
        }

        //עדכון
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateProject(Project ProjectToUpdate)
        {
            Project ProjectFromDb = await _context.Projects.FirstOrDefaultAsync(p => p.ID == ProjectToUpdate.ID);

            if (ProjectFromDb != null)
            {
                ProjectFromDb.ProjectName = ProjectToUpdate.ProjectName;
                ProjectFromDb.SoftwareName = ProjectToUpdate.SoftwareName;
                ProjectFromDb.FullName = ProjectToUpdate.FullName;
                ProjectFromDb.Introduction = ProjectToUpdate.Introduction;
                ProjectFromDb.ColorDesign = ProjectToUpdate.ColorDesign;
                ProjectFromDb.BlockID = ProjectToUpdate.BlockID;

                ProjectFromDb.UpdateDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return Ok(ProjectFromDb);
            }
            else
            {
                return Ok("no such Project...");
            }
        }
    }
}

