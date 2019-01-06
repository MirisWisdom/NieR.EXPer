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
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using YuMi.NieRexper.GUI.Annotations;

namespace YuMi.NieRexper.GUI
{
    /// <summary>
    ///     Main model for the GUI.
    /// </summary>
    public class Main : INotifyPropertyChanged
    {
        /// <summary>
        ///     <see cref="ExpLevel" />
        /// </summary>
        private int _expLevel;

        /// <summary>
        ///     <see cref="SaveSlot" />
        /// </summary>
        private int _saveSlot;

        /// <summary>
        ///     <see cref="Status" />
        /// </summary>
        private string _status = "PENDING";

        /// <summary>
        ///     Selected save slot.
        /// </summary>
        public int SaveSlot
        {
            get => _saveSlot;
            set
            {
                if (value == _saveSlot) return;
                _saveSlot = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Wanted level.
        /// </summary>
        public int ExpLevel
        {
            get => _expLevel;
            set
            {
                if (value == _expLevel) return;
                _expLevel = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Current program status.
        /// </summary>
        public string Status
        {
            get => _status;
            set
            {
                if (value == _status) return;
                _status = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Invokes the library's EXP calculation & slot patching components.
        /// </summary>
        public void SaveData()
        {
            try
            {
                var levelExp = ExperienceFactory.FromLevel((Level) ExpLevel);
                new ExperienceRepository((Slot) SaveSlot).Save(levelExp);

                Status = "SUCCESS";
            }
            catch (Exception exception)
            {
                Status = exception.Message;
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}