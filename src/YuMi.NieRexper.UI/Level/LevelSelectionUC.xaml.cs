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

namespace YuMi.NieRexper.UI.Level
{
    /// <summary>
    ///     Interaction logic for LevelSelectionUC.xaml
    /// </summary>
    public partial class LevelSelectionUC : UserControl
    {
        public EventHandler AppliedCustomLevel;
        public EventHandler AppliedLevel10;
        public EventHandler AppliedLevel25;
        public EventHandler AppliedLevel50;
        public EventHandler AppliedLevel75;

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