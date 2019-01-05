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
using System.IO;
using System.Threading.Tasks;

namespace YuMi.NieRexper.CLI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Not enough args.");
                Environment.Exit(1);
            }

            try
            {
                Task.Run(() =>
                {
                    var levelExp = ExperienceFactory.FromLevel((Level) int.Parse(args[0]));
                    Console.WriteLine($"Infer points value: [{levelExp.Points}] <= [{args[0]}]");

                    var personal = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    var fullPath = Path.Combine(personal, "My Games", "NieR_Automata", $"SlotData_{args[1]}.dat");

                    var saveSloth = (Slot) fullPath;
                    Console.WriteLine($"Patching save slot: [{saveSloth.Path}] <= [{levelExp.Points}]");

                    new ExperienceRepository(saveSloth).Save(levelExp);
                    Console.WriteLine($"Successfully saved: [{args[1]}] <= [{args[0]}]");
                }).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                Environment.Exit(1);
            }
        }
    }
}