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

namespace YuMi.NieRexper
{
    /// <summary>
    ///     Serialises Experience object to a save slot file.
    /// </summary>
    public class ExperienceRepository
    {
        /// <summary>
        ///     Offset in the slot binary where the EXP value is stored.
        /// </summary>
        private const int LevelOffset = 0x3871C;

        /// <summary>
        ///     NieR:Automata save slot used for the Experience serialisation.
        /// </summary>
        private readonly Slot _slot;

        /// <summary>
        ///     ExperienceRepository constructor.
        /// </summary>
        /// <param name="slot">
        ///     NieR:Automata Slot slot used for the Experience serialisation.
        /// </param>
        public ExperienceRepository(Slot slot)
        {
            _slot = slot;
        }

        /// <summary>
        ///     Serialise Experience object to the given Slot file.
        /// </summary>
        /// <param name="experience">
        ///     Experience object to serialise.
        /// </param>
        public void Save(Experience experience)
        {
            if (!File.Exists(_slot))
                throw new FileNotFoundException("Slot not found.");

            BackupSave();
            SavePoints(experience);
        }

        private void SavePoints(Experience experience)
        {
            using (var writer = new BinaryWriter(File.OpenWrite(_slot)))
            {
                var points = BitConverter.GetBytes(experience.Points);
                writer.BaseStream.Seek(LevelOffset, SeekOrigin.Begin);
                writer.Write(points, 0, points.Length);
            }
        }

        private void BackupSave()
        {
            var slotFileName = Path.GetFileName(_slot)
                               ?? throw new FormatException("Cannot infer file name from Slot path.");

            var sourceFolder = Path.GetDirectoryName(_slot)
                               ?? throw new FormatException("Cannot infer directory from Slot path.");

            var backupFolder = Path.Combine(sourceFolder, "NieR.EXPer", Guid.NewGuid().ToString());

            Directory.CreateDirectory(backupFolder);
            File.Copy(_slot, Path.Combine(backupFolder, slotFileName));
        }
    }
}