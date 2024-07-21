using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_SapirTeper_OfirEinhoren.Shared.BlocksClass
{
    public class QManyChoicesBlock
    {
        public string ManyChoices_Ques { get; set; }
        public string[] ManyChoices_AnsArray { get; set; }
        public bool[] ManyChoices_TrueAnsBool { get; set; }
        public string ManyChoices_FeedbackTrue { get; set; }
        public string ManyChoices_FeedbackFalse { get; set; }
    }
}
