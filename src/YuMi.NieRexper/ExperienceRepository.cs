using System;
using System.IO;

namespace YuMi.NieRexper
{
    /// <summary>
    ///     Serialises Experience object to Save file.
    /// </summary>
    public class ExperienceRepository
    {
        /// <summary>
        ///     Offset in the save binary where the EXP value is stored.
        /// </summary>
        private const int LevelOffset = 0x3871C;

        /// <summary>
        ///     NieR:Automata Save slot used for the Experience serialisation.
        /// </summary>
        private readonly Save _save;

        /// <summary>
        ///     ExperienceRepository constructor.
        /// </summary>
        /// <param name="save">
        ///     NieR:Automata Save slot used for the Experience serialisation.
        /// </param>
        public ExperienceRepository(Save save)
        {
            _save = save;
        }

        /// <summary>
        ///     Serialise Experience object to the given Save file.
        /// </summary>
        /// <param name="experience">
        ///     Experience object to serialise.
        /// </param>
        public void Save(Experience experience)
        {
            if (File.Exists(_save))
                throw new FileNotFoundException("Slot not found.");

            BackupSave();
            SavePoints(experience);
        }

        private void SavePoints(Experience experience)
        {
            using (var writer = new BinaryWriter(File.OpenWrite(_save)))
            {
                var points = BitConverter.GetBytes(experience.Points);
                writer.BaseStream.Seek(LevelOffset, SeekOrigin.Begin);
                writer.Write(points, 0, points.Length);
            }
        }

        private void BackupSave()
        {
            var slotFileName = Path.GetFileName(_save)
                               ?? throw new FormatException("Cannot infer file name from Save path.");

            var sourceFolder = Path.GetDirectoryName(_save)
                               ?? throw new FormatException("Cannot infer directory from Save path.");

            var backupFolder = Path.Combine(sourceFolder, $"NieR.EXPer-{Guid.NewGuid()}");

            Directory.CreateDirectory(backupFolder);
            File.Copy(_save, Path.Combine(backupFolder, slotFileName));
        }
    }
}