using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using HocWPF.Model;

namespace HocWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WinMain : Window
    {
        public Employee First = new Employee() {
            FirstName = "Nghia",
            Favorite ="Fish"
        };

        public WinMain()
        {
            InitializeComponent();

            

            //Binding bindTenThich = new Binding();
            //bindTenThich.Mode = BindingMode.OneWay;
            //bindTenThich.Source = First;
            //bindTenThich.Path = new PropertyPath("TString");

            //TenThich.SetBinding(Label.ContentProperty, bindTenThich);

            //Binding bindTen = new Binding();
            //bindTen.Mode = BindingMode.TwoWay;
            //bindTen.Source = First;
            //bindTen.Path = new PropertyPath("FirstName");

            //Ten.SetBinding(TextBox.TextProperty, bindTen);

            //Binding bindThich = new Binding();
            //bindThich.Mode = BindingMode.TwoWay;
            //bindThich.Source = First;
            //bindThich.Path = new PropertyPath("Favorite");

            //Thich.SetBinding(TextBox.TextProperty, bindThich);

            //MultiBinding bindTenThich = new MultiBinding();
            //bindTenThich.Mode = BindingMode.OneWay;
            //bindTenThich.Bindings.Add(bindTen);
            //bindTenThich.Bindings.Add(bindThich);
            //bindTenThich.Converter = ;

            //TenThich.SetBinding(Label.ContentProperty, bindTenThich);
        }

        private void BtnNhap_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(First.TString);
        }
    }
}
