using System;
using System.Windows;
using System.Windows.Controls;

namespace YuMi.NieRexper.UI.Level
{
    /// <summary>
    /// Interaction logic for LevelSelectionUC.xaml
    /// </summary>
    public partial class LevelSelectionUC : UserControl
    {
        public EventHandler AppliedLevel10;
        public EventHandler AppliedLevel25;
        public EventHandler AppliedLevel50;
        public EventHandler AppliedLevel75;
        public EventHandler AppliedCustomLevel;

        public LevelSelectionUC()
        {
            InitializeComponent();
        }

        private void ApplyLevel10(object sender, RoutedEventArgs e)
        {
            AppliedLevel10?.Invoke(this, e);
        }

        private void ApplyLevel25(object sender, RoutedEventArgs e)
        {
            AppliedLevel25?.Invoke(this, e);
        }

        private void ApplyLevel50(object sender, RoutedEventArgs e)
        {
            AppliedLevel50?.Invoke(this, e);
        }

        private void ApplyLevel75(object sender, RoutedEventArgs e)
        {
            AppliedLevel75?.Invoke(this, e);
        }

        private void ApplyCustomLevel(object sender, RoutedEventArgs e)
        {
            AppliedCustomLevel?.Invoke(this, e);
        }
    }
}
