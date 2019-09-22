using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class BaseCellViewModel
    {
        public BaseCellViewModel(string name, int colName)
        {
            Name = name; 
            ColName = ((char)('A' + colName)).ToString();
        }

        public string Name { get; set; }

        public string ColName { get; set; }
    }
}
