using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_SapirTeper_OfirEinhoren.Shared.BlocksClass
{
    public class QOneChoiceBlock
    {
        public string OneChoice_Ques { get; set; }
        public string[] OneChoice_AnsArray { get; set; }
        public string OneChoice_TrueAns { get; set; }
        public string OneChoice_FeedbackTrue { get; set; }
        public string OneChoice_FeedbackFalse { get; set; }
    } 
}
