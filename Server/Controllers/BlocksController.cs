using FinalProject_SapirTeper_OfirEinhoren.Server.Data;
using FinalProject_SapirTeper_OfirEinhoren.Server.Helpers;
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
    public class BlocksController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly FileStorage _fileStorage;

        public BlocksController(DataContext context, FileStorage fileStorage)
        {
            _context = context;
            _fileStorage = fileStorage;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlock(int id)
        {
            Console.WriteLine("2");
            //רשומה הראשונה ששווה לID
            Block Block = await _context.Blocks.FirstOrDefaultAsync(b => b.ProjectID == id);
            if (Block != null)
            {
                Console.WriteLine("2 מלא");
                return Ok(Block);
                
            }
            else
            {
                Console.WriteLine("2 ריק");
                return BadRequest("no such Block...");
            }
            
        }


        //רשימה של הבלוקים הקיימים לאותו פרוייקט
        [HttpGet("ListPerProject/{id}")]
        public async Task<IActionResult> GetBlocksPerProject(int id)
        {
            //רשימה של רשומות ששוות לאותו פרוייקט - ID
            List<Block> ListOfBlock = await _context.Blocks.Where(b => b.ProjectID == id).OrderBy(b => b.Rank).ToListAsync();

            if (ListOfBlock != null)
            {
                return Ok(ListOfBlock);
            }
            else
            {
                return BadRequest("no such Block...");
            }
        }


        //מחיקה
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlock(int id)
        {
            Block Block = await _context.Blocks.FirstOrDefaultAsync(b => b.ID == id);
            if (Block != null)
            {
                _context.Blocks.Remove(Block);
                await _context.SaveChangesAsync();
                return Ok(true);
            }
            else
            {
                return BadRequest("no such Block...");
            }
        }


        //הוספה
        [HttpPost("Insert")]
        public async Task<IActionResult> AddBlock(Block Block)
        {
            if (Block != null)
            {
                _context.Blocks.Add(Block);
                await _context.SaveChangesAsync();
                return Ok(Block);
            }
            else
            {
                return BadRequest("Block was not send");
            }
        }


        //הוספה
        [HttpPost("Insert1/{ProjectID}")]
        public async Task<IActionResult> AddBlock1(int ProjectID, Block Block)
        {
            if (Block != null)
            {
                Block.ProjectID = ProjectID;
                _context.Blocks.Add(Block);
                await _context.SaveChangesAsync();
                return Ok(Block);
            }
            else
            {
                return BadRequest("Block was not send");
            }
        }




        //עדכון
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateBlock(Block BlockToUpdate)
        {
            
            Block BlockFromDb = await _context.Blocks.FirstOrDefaultAsync(w => w.ID == BlockToUpdate.ID);

            if (BlockFromDb != null)
            {
                BlockFromDb.BlockContent = BlockToUpdate.BlockContent;
                BlockFromDb.BlockType = BlockToUpdate.BlockType;
                BlockFromDb.ProjectID = BlockToUpdate.ProjectID;
                BlockFromDb.Rank = BlockToUpdate.Rank;
                BlockFromDb.Number = BlockToUpdate.Number;
                BlockFromDb.ToContinue = BlockToUpdate.ToContinue;

                await _context.SaveChangesAsync();
                return Ok(BlockFromDb);
            }
            else
            {
                return BadRequest("no such Block...");
            }
        }


        //העלאת תמונה
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromBody] string imageBase64)
        {
            byte[] picture = Convert.FromBase64String(imageBase64);
            string url = await _fileStorage.SaveFile(picture, "png", "uploadedFiles");
            return Ok(url);
        }

        //מחיקת תמונה
        [HttpPost("deleteImages")]
        public async Task<IActionResult> DeleteImages([FromBody] string img)
        {
            await _fileStorage.DeleteFile(img, "uploadedFiles");
            return Ok("deleted");
        }


       
        //העלאת תמונה
        [HttpPost("updateImage")]
        public async Task<IActionResult> updateImage([FromBody]List<string> strings)
        {
            byte[] picture = Convert.FromBase64String(strings[0]);
            string url = await _fileStorage.EditFile(picture, "png", "uploadedFiles", strings[1]);
            return Ok(url);
        }

    }
}
