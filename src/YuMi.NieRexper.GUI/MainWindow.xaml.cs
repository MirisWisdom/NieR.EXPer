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

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using MahApps.Metro.Controls;

namespace YuMi.NieRexper.GUI
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly Main _main;

        public MainWindow()
        {
            InitializeComponent();
            _main = (Main) DataContext;

            MainTabControl.SelectedItem = SaveSlotTabItem;
        }

        private void SetSaveSlot00(object sender, RoutedEventArgs e)
        {
            SetSaveSaveSlot(0);
        }

        private void SetSaveSlot01(object sender, RoutedEventArgs e)
        {
            SetSaveSaveSlot(1);
        }

        private void SetSaveSlot02(object sender, RoutedEventArgs e)
        {
            SetSaveSaveSlot(2);
        }

        private void SetExpLevel10(object sender, RoutedEventArgs e)
        {
            SetExpLevel(10);
        }

        private void SetExpLevel25(object sender, RoutedEventArgs e)
        {
            SetExpLevel(25);
        }

        private void SetExpLevel50(object sender, RoutedEventArgs e)
        {
            SetExpLevel(50);
        }

        private void SetExpLevel75(object sender, RoutedEventArgs e)
        {
            SetExpLevel(75);
        }

        private void SetSaveSaveSlot(int slot)
        {
            _main.SaveSlot = slot;
            MainTabControl.SelectedItem = ExpLevelTabItem;
        }

        private void SetExpLevel(int level)
        {
            _main.ExpLevel = level;
            Task.Run(() =>
            {
                _main.SaveData(); 
                Thread.Sleep(2500);
                _main.Status = "PENDING";
            });
        }

        private void SetCustomExpLevel(object sender, RoutedEventArgs e)
        {
            _main.SaveData();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/yumiris/NieR.EXPer");
        }
    }
}