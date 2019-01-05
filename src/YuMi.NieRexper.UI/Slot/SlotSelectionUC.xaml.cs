using System;
using System.Windows;
using System.Windows.Controls;

namespace YuMi.NieRexper.UI.Slot
{
    /// <summary>
    /// Interaction logic for SlotSelectionUC.xaml
    /// </summary>
    public partial class SlotSelectionUC : UserControl
    {
        public EventHandler Slot0Selected;
        public EventHandler Slot1Selected;
        public EventHandler Slot2Selected;

        public SlotSelectionUC()
        {
            InitializeComponent();
        }

        private void SelectSlot0(object sender, RoutedEventArgs e)
        {
            Slot0Selected?.Invoke(this, e);
        }

        private void SelectSlot1(object sender, RoutedEventArgs e)
        {
            Slot1Selected?.Invoke(this, e);
        }

        private void SelectSlot2(object sender, RoutedEventArgs e)
        {
            Slot2Selected?.Invoke(this, e);
        }
    }
}
