/**
 * Copyright (C) 2018-2019 Emilian Roman
 * 
 * This file is part of NieR.EXPer.
 * 
 * NieR.EXPer is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * NieR.EXPer is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with NieR.EXPer.  If not, see <http://www.gnu.org/licenses/>.
 */

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
