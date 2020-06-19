using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardWithMetro
{
    public class Sprint
    {
        public int Sprint_ID { get; set; }
        public string Sprint_Name { get; set; }
        public string Sprint_DeadLine { get; set; }

        public int ProjectID { get; set; }
    }
}
