using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using YuMi.NieRexper.Apply.Common;

namespace YuMi.NieRexper.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        Main main = new Main();

        string statusText = Properties.Resources.StatusAwaiting;

        /// <summary>
        /// Full path for the NieR:Automata saves directory: Documents\My Games\NieR_Automata
        /// </summary>
        string SavesDirectory {
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
        /// Prompt the user with a dialogue window to choose their save slot and apply the specified EXP value.
        /// </summary>
        /// <param name="amount">Amount of EXP to apply to the save slot the user will choose.</param>
        public void ApplyEXP(int amount)
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = SavesDirectory,
                Filter = Properties.Resources.SavesFilter
            };

            if (openFileDialog.ShowDialog() == true)
            {
                var fileName = openFileDialog.FileName;
                var copyName = GetUniqueSlotName(fileName);

                File.Copy(fileName, copyName, true);

                var result = main.Apply(amount, fileName);

                if (result.Status == PatchStatus.Success)
                {
                    StatusText = Properties.Resources.StatusSuccess;
                }
                else
                {
                    statusText = result.Data;
                }
            }
        }

        /// <summary>
        /// Returns the inbound save slot's file name with an unique string padded into it.
        /// </summary>
        /// <param name="fileName">Absolute path, e.g. C:\SlotData_0.dat</param>
        /// <returns>Unique..ified... save slot file name, e.g. C:\SlotData_0_5d8fe167.dat</returns>
        string GetUniqueSlotName(string fileName)
        {
            var fileNameNoExtension = fileName.Substring(0, fileName.Length - 4);
            var guidWithFirst8Chars = Guid.NewGuid().ToString().Substring(0, 8);
            return $"{fileNameNoExtension}-{guidWithFirst8Chars}.dat";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
