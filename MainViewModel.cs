using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace YuMi.NieRexper
{
    public class MainViewModel : INotifyPropertyChanged
    {
        Main main = new Main();

        string statusText = Properties.Resources.StatusAwaiting;

        string SavesDirectory {
            get {
                var myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return Path.Combine(myDocs, Properties.Resources.GamesDirectory, Properties.Resources.SavesDirectory);
            }
        }

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

        public void ApplyEXP(int amount)
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = SavesDirectory,
                Filter = Properties.Resources.SavesFilter
            };

            if (openFileDialog.ShowDialog() == true)
            {
                var result = main.Apply(amount, openFileDialog.FileName);

                if (result.Status == LevelApplyStatus.Success)
                {
                    StatusText = Properties.Resources.StatusSuccess;
                }
                else
                {
                    statusText = result.Data;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
