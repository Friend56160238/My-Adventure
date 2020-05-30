using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteDB
{
    class Adventure
    {
        public int id { get; set; }
        public string activityName { get; set; }
        public DateTime activityDate { get; set; }
        public string address { get; set; }
        public decimal lon { get; set; }
        public decimal lat { get; set; }
    }
}
