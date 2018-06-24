using System.Windows;

namespace YuMi.NieRexper
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
    }
}
