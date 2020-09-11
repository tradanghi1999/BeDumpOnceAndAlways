using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RenewDotNetCoreWPF
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }
        private void OnInit(object sender, RoutedEventArgs e)
        {
            DataContext = new AuctionItem("Type your description here",
                ProductCategory.DvDs, 1, DateTime.Now, ((App)Application.Current).CurrentUser,
                SpecialFeatures.None);
        }

        private void SubmitProduct(object sender, RoutedEventArgs e)
        {
            var item = (AuctionItem)(DataContext);
            ((App)Application.Current).AuctionItems.Add(item);
            Close();
        }
    }
}
