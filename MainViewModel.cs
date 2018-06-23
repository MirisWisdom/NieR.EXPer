using Microsoft.Win32;
using System;
using System.IO;

namespace YuMi.NieRexper
{
    public class MainViewModel
    {
        Main main = new Main();

        string SavesDirectory {
            get {
                var myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return Path.Combine(myDocs, "My Games", "NieR_Automata");
            }
        }

        public void ApplyEXP(int amount)
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = SavesDirectory,
                Filter = "N:A Saves (SlotData_*.dat)|SlotData_*.dat"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                main.Apply(amount, openFileDialog.FileName);
            }
        }
    }
}
