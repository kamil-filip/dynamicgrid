using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Record
    {

        public Record(int row, int cells)
        {

            Name = row.ToString();

            for(int i =0; i< cells; i++)
            {
                Cells.Add(new BaseCellViewModel($"{row}:{i}", i));
            }


        }

        public string Name{ get; set; }


        public ObservableCollection<BaseCellViewModel> Cells { get; set; } = new ObservableCollection<BaseCellViewModel>();

    }
}
