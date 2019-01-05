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

﻿using System;
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
