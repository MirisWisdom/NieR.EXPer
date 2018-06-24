using System.Windows;

namespace YuMi.NieRexper.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        void ApplyLevel10(object sender, RoutedEventArgs e)
        {
            viewModel.ApplyEXP(Main.Level10);
        }

        void ApplyLevel25(object sender, RoutedEventArgs e)
        {
            viewModel.ApplyEXP(Main.Level25);
        }

        void ApplyLevel50(object sender, RoutedEventArgs e)
        {
            viewModel.ApplyEXP(Main.Level50);
        }

        void ApplyLevel75(object sender, RoutedEventArgs e)
        {
            viewModel.ApplyEXP(Main.Level75);
        }

        void SelectSlot0(object sender, RoutedEventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData0;
        }

        void SelectSlot1(object sender, RoutedEventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData1;
        }

        void SelectSlot2(object sender, RoutedEventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData2;
        }
    }
}
