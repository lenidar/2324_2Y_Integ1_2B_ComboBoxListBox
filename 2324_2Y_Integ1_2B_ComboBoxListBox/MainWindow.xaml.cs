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

namespace _2324_2Y_Integ1_2B_ComboBoxListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListViewItem lvi1 = null;
        ListViewItem lvi2 = null;

        public MainWindow()
        {
            InitializeComponent();

            lvi1 = new ListViewItem();
            lvi1.Content = "Derrick";
            lvi1.Tag = "Mauricio";
            cbSample.Items.Add(lvi1);
            lvi1 = new ListViewItem();
            lvi1.Content = "Ira";
            lvi1.Tag = "Herrera";
            cbSample.Items.Add(lvi1);
            lvi1 = new ListViewItem();
            lvi1.Content = "Christian";
            lvi1.Tag = "Jost";
            cbSample.Items.Add(lvi1);
            lvi1 = new ListViewItem();
            lvi1.Content = "Josep";
            lvi1.Tag = "Gaffud";
            cbSample.Items.Add(lvi1);
            lvi1 = new ListViewItem();
            lvi1.Content = "Claude";
            lvi1.Tag = "Gallardo";
            cbSample.Items.Add(lvi1);
            lvi1 = new ListViewItem();
            lvi1.Content = "Sho";
            lvi1.Tag = "Terashita";
            cbSample.Items.Add(lvi1);

            lvi2 = new ListViewItem();
            lvi2.Content = "Derrick";
            lvi2.Tag = "Mauricio";
            lbDisplay.Items.Add(lvi2);
            lvi2 = new ListViewItem();
            lvi2.Content = "Ira";
            lvi2.Tag = "Herrera";
            lbDisplay.Items.Add(lvi2);
            lvi2 = new ListViewItem();
            lvi2.Content = "Christian";
            lvi2.Tag = "Jost";
            lbDisplay.Items.Add(lvi2);
            lvi2 = new ListViewItem();
            lvi2.Content = "Josep";
            lvi2.Tag = "Gaffud";
            lbDisplay.Items.Add(lvi2);
            lvi2 = new ListViewItem();
            lvi2.Content = "Claude";
            lvi2.Tag = "Gallardo";
            lbDisplay.Items.Add(lvi2);
            lvi2 = new ListViewItem();
            lvi2.Content = "Sho";
            lvi2.Tag = "Terashita";
            //lvi2.FontSize = 20;
            lbDisplay.Items.Add(lvi2);
        }

        private void cbSample_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(cbSample.SelectedItem.ToString());
            ListViewItem d1 = (ListViewItem)cbSample.SelectedItem;
            MessageBox.Show(d1.Tag.ToString());
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(lbDisplay.SelectedItem.ToString());
            ListViewItem d1 = (ListViewItem)lbDisplay.SelectedItem;
            MessageBox.Show(d1.Tag.ToString());
        }
    }
}
