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
            if (File.Exists(_slot))
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

            var backupFolder = Path.Combine(sourceFolder, $"NieR.EXPer-{Guid.NewGuid()}");

            Directory.CreateDirectory(backupFolder);
            File.Copy(_slot, Path.Combine(backupFolder, slotFileName));
        }
    }
}