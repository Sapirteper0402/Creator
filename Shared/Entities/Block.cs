using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_SapirTeper_OfirEinhoren.Shared.Entities
{
    public class Block
    {
        public int ID { get; set; }
        public string BlockContent { get; set; }
        public string BlockType { get; set; }
        public int ProjectID { get; set; }
        public int Rank { get; set; }
        public int Number { get; set; }
        public int ToContinue { get; set; }

        public Project BlockProject { get; set; }
    }
}
