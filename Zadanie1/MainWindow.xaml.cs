using System.Windows;

namespace Zadanie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IRandomizer randomizer;
        public MainWindow()
        {
            InitializeComponent();
            randomizer = new Randomizer();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            randomizer.AddNewCoupon(TextBox_NewItemName.Text);
            Label_LastOperation.Content = "Added item " + TextBox_NewItemName.Text;
            TextBox_NewItemName.Text = "";
            RefreshList();
        }

        private void GetRandom_Click(object sender, RoutedEventArgs e)
        {
            string randomCoupon = randomizer.GetRandomCoupon();
            Label_LastRandomItem.Content = randomCoupon;
            Label_LastOperation.Content = "Extracted random item " + randomCoupon;
            RefreshList();
        }

        private void RefreshList()
        {
            ListBox_Main.Items.Clear();
            randomizer.GetAllCoupons().ForEach(x => ListBox_Main.Items.Add(x));
        }
    }
}
