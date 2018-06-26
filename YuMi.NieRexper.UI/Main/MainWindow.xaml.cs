using System;
using System.Windows;

namespace YuMi.NieRexper.UI.Main
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

            SlotSelection.Slot0Selected += SelectSlot0;
            SlotSelection.Slot1Selected += SelectSlot1;
            SlotSelection.Slot2Selected += SelectSlot2;

            LevelSelection.AppliedLevel10 += ApplyLevel10;
            LevelSelection.AppliedLevel25 += ApplyLevel25;
            LevelSelection.AppliedLevel50 += ApplyLevel50;
            LevelSelection.AppliedLevel75 += ApplyLevel75;
            LevelSelection.AppliedCustomLevel += ApplyCustomLevel;
        }

        void ApplyLevel10(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level10);
        }

        void ApplyLevel25(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level25);
        }

        void ApplyLevel50(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level50);
        }

        void ApplyLevel75(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level75);
        }

        void ApplyCustomLevel(object sender, EventArgs e)
        {
            viewModel.ApplyCustomLevel();
        }

        void SelectSlot0(object sender, EventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData0;
        }

        void SelectSlot1(object sender, EventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData1;
        }

        void SelectSlot2(object sender, EventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData2;
        }
    }
}
