using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knockout.model
{
    public class Master
    {

        public int Id { get; set; }
        public String FName { get; set; }
        public String MName { get; set; }
        public String LName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Citizenship { get; set; }

        public List<Details> DetailsList { get; set; }
    }
}
