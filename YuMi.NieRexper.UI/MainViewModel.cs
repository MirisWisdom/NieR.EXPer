using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using YuMi.NieRexper.Apply.Common;
using YuMi.NieRexper.Calculate;

namespace YuMi.NieRexper.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        Main main = new Main();

        string statusText = Properties.Resources.StatusAwaiting;

        string slotFile = string.Empty;

        uint customLevel = 25;

        Visibility slotsGridVisibility = Visibility.Visible;

        Visibility levelsGridVisibility = Visibility.Collapsed;

        /// <summary>
        /// Full path for the NieR:Automata saves directory: Documents\My Games\NieR_Automata
        /// </summary>
        string SlotsDirectory {
            get {
                var myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return Path.Combine(myDocs, Properties.Resources.GamesDirectory, Properties.Resources.SavesDirectory);
            }
        }

        /// <summary>
        /// Text representation of the outcome status.
        /// </summary>
        public string StatusText {
            get {
                return statusText;
            }
            set {
                if (value != statusText)
                {
                    statusText = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Absolute path representation of the selected slot.
        /// </summary>
        public string SlotFile {
            get {
                return slotFile;
            }
            set {
                if (value != slotFile)
                {
                    slotFile = value;
                    NotifyPropertyChanged();
                    SlotsGridVisibility = Visibility.Collapsed;
                    LevelsGridVisibility = Visibility.Visible;
                }
            }
        }

        /// <summary>
        /// Property representing the custom level typed by the user.
        /// </summary>
        public uint CustomLevel {
            get {
                return customLevel;
            }
            set {
                if (value != customLevel)
                {
                    customLevel = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Toggles whether the Slot 0 selection button is enabled or not depending on Slot 0's existence.
        /// </summary>
        public bool Slot0ButtonEnabled {
            get {
                return SlotExists(Properties.Resources.SlotData0);
            }
        }

        /// <summary>
        /// Toggles whether the Slot 0 selection button is enabled or not depending on Slot 1's existence.
        /// </summary>
        public bool Slot1ButtonEnabled {
            get {
                return SlotExists(Properties.Resources.SlotData1);
            }
        }

        /// <summary>
        /// Toggles whether the Slot 0 selection button is enabled or not depending on Slot 2's existence.
        /// </summary>
        public bool Slot2ButtonEnabled {
            get {
                return SlotExists(Properties.Resources.SlotData2);
            }
        }

        /// <summary>
        /// Toggle visibility based on whether a slot has been selected or not.
        /// </summary>
        public Visibility SlotsGridVisibility {
            get {
                return slotsGridVisibility;
            }
            set {
                if (slotsGridVisibility != value)
                {
                    slotsGridVisibility = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Toggle visibility based on whether a slot has been selected or not.
        /// </summary>
        public Visibility LevelsGridVisibility {
            get {
                return levelsGridVisibility;
            }
            set {
                if (levelsGridVisibility != value)
                {
                    levelsGridVisibility = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Prompt the user with a dialogue window to choose their save slot and apply the specified EXP value.
        /// </summary>
        /// <param name="amount">Amount of EXP to apply to the save slot the user will choose.</param>
        public void ApplyEXP(int amount)
        {
            var result = main.PatchSlot(Path.Combine(SlotsDirectory, SlotFile), amount);

            StatusText = result.Status == PatchStatus.Success
                ? Properties.Resources.StatusSuccess
                : result.Data;
        }

        /// <summary>
        /// Calls ApplyEXP that with the CustomLevel's value as the argument.
        /// </summary>
        public void ApplyCustomLevel()
        {
            ApplyEXP(new ExpCalculate().Calculate((int)CustomLevel));
        }

        /// <summary>
        /// Checks the NieR:Automata saves (slots) directory for the existence of the specified slot file.
        /// </summary>
        /// <param name="slot">Slot file to check, e.g. SlotData_0.dat</param>
        /// <returns>Provided slot file exists on the filesystem.</returns>
        bool SlotExists(string slot)
        {
            return File.Exists(Path.Combine(SlotsDirectory, slot));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
