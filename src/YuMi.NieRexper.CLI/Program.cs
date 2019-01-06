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
using System.Threading.Tasks;

namespace YuMi.NieRexper.CLI
{
    /// <summary>
    ///     NieR.EXPer CLI
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///     CLI entry.
        /// </summary>
        /// <param name="args">
        ///     [0] = Desired level (1..99)
        ///     [1] = Save slot number (0..2)
        /// </param>
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

                    var saveSloth = (Slot) int.Parse(args[1]);
                    Console.WriteLine($"Patching save slot: [{levelExp.Points}] => [{args[1]}]");

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