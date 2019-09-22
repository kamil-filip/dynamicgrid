using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyGridViewModel
    {


        public MyGridViewModel()
        {
        
        }



        public ObservableCollection<Record> Records { get; set; } = new ObservableCollection<Record>();

        internal ObservableCollection<Record> Get()
        {
            for (int i = 0; i < 2000; i++)
            {
                Records.Add(new Record(i, 32));
            }

            Console.WriteLine("To bind: " + 30 * 100);

            return Records;
        }
    }
}
