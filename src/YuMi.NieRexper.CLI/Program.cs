using System;
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

                    var saveSloth = (Slot) args[1];
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