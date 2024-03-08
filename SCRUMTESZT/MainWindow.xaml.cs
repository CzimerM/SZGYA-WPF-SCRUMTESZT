using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCRUMTESZT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txbNev.IsEnabled = false;
            txbMail.IsEnabled = false;
            lbx1f.IsEnabled = false;
            cmb2f.IsEnabled = false;
            stckp3f.IsEnabled = false;
            stckp4f.IsEnabled = false;
            txb5f.IsEnabled = false;
        }

        private void btnKesz_Click(object sender, RoutedEventArgs e)
        {
            lblValasz1.Content = ((ListBoxItem)lbx1f.SelectedItem).Content;

            lblValasz2.Content = ((ComboBoxItem)cmb2f.SelectedItem).Content;

            lbxValasz3.Items.Clear();
            foreach (CheckBox b in stckp3f.Children)
            {
                if ((bool)b.IsChecked) lbxValasz3.Items.Add(b.Content);
            }

            foreach (RadioButton b in stckp4f.Children)
            { 
                if ((bool)b.IsChecked)
                {
                    lblValasz4.Content = b.Content;
                    break;
                } 
            }

            lblValasz5.Content = txb5f.Text;

            MessageBox.Show($"Kedves {txbNev.Text}! Kéri-e továbbítani az eredményt az álábbi e-mail címre: {txbMail.Text}?", "Eredmény", MessageBoxButton.YesNoCancel);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txbNev.IsEnabled = true;
            txbMail.IsEnabled = true;
            lbx1f.IsEnabled = true;
            cmb2f.IsEnabled = true;
            stckp3f.IsEnabled = true;
            stckp4f.IsEnabled = true;
            txb5f.IsEnabled = true;
        }
    }
}