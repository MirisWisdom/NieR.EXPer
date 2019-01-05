using System;
using System.Windows;

namespace YuMi.NieRexper.UI.Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel = new MainViewModel();

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

        private void ApplyLevel10(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level10);
        }

        private void ApplyLevel25(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level25);
        }

        private void ApplyLevel50(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level50);
        }

        private void ApplyLevel75(object sender, EventArgs e)
        {
            viewModel.ApplyEXP(Main.Level75);
        }

        private void ApplyCustomLevel(object sender, EventArgs e)
        {
            viewModel.ApplyCustomLevel();
        }

        private void SelectSlot0(object sender, EventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData0;
        }

        private void SelectSlot1(object sender, EventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData1;
        }

        private void SelectSlot2(object sender, EventArgs e)
        {
            viewModel.SlotFile = Properties.Resources.SlotData2;
        }
    }
}
