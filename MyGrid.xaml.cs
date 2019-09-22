using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp6.Properties;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MyGrid.xaml
    /// </summary>
    public partial class MyGrid : UserControl
    {

        private MyGridViewModel _vm;

        public MyGrid()
        {
            InitializeComponent();
            _vm = new MyGridViewModel();

            DataContext = _vm;

            Grid.ItemsSource = _vm.Get();

            Grid.Columns.Clear();

            var columns = _vm.Records.First()
                .Cells
                .Select((x, i) => new { Name = x.ColName, Index = i })
                .ToArray();

            foreach (var column in columns)
            {
                var binding = new Binding(string.Format("Cells[{0}]", column.Index));

                Grid.Columns.Add(new CustomBoundColumn()
                {
                    Header = column.Name,
                    Binding = binding,
                    TemplateName = "CustomTemplate"
                });
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        


            //Grid.Items.Refresh();

           // Grid.ItemsSource = _vm.Get();
        }

        private bool _canrefresh;

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Grid.Items.Refresh();


            //  Console.WriteLine("can refresh");
            //  _canrefresh = true;
            // Grid.ItemsSource = null;


            //CollectionViewSource.GetDefaultView(Grid.ItemsSource).Refresh();

        }
        private int counter = 0;
        private void Grid_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
  //          Console.WriteLine("Records count = " + _vm.Records.Count());
            Console.WriteLine("it is scrolling" + counter++);
            if(_canrefresh)
            {
//                Console.WriteLine("refreshed");
              //  Thread.Sleep(2000);
                
            }
                //CollectionViewSource.GetDefaultView(Grid.ItemsSource).Refresh();
        }
    }
}
