using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_SapirTeper_OfirEinhoren.Shared.Entities
{
    public class Project
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string SoftwareName { get; set; }
        public string FullName { get; set; }
        public string Introduction { get; set; }
        public string ColorDesign { get; set; }
        public int BlockID { get; set; }
        
        public List<Block> ProjectBlocks { get; set; }
    }
}
