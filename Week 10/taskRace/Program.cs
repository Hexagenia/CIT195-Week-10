using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read, Set, Go...");

            
            int[] locations = new int[5];

            
            Task[] tasks = new Task[5];
            tasks[0] = CreateRacerTask("Speedy Gonzales", 0, locations);
            tasks[1] = CreateRacerTask("Road Runner", 1, locations);
            tasks[2] = CreateRacerTask("Flash", 2, locations);
            tasks[3] = CreateRacerTask("Sonic", 3, locations);
            tasks[4] = CreateRacerTask("Flash Gordon", 4, locations);

            
            Task.WaitAny(tasks);

            Console.WriteLine("Race has ended");
        }

        static Task CreateRacerTask(string name, int index, int[] locations)
        {
            return Task.Run(() =>
            {
                Thread.CurrentThread.Name = name;
                for (int i = 0; i < 100; i++)
                {
                   
                    if (AllLocationsUnder100(locations))
                        MoveRacer(ref locations[index]);
                }
            });
        }

        static bool AllLocationsUnder100(int[] locations)
        {
            foreach (int loc in locations)
            {
                if (loc >= 100)
                    return false;
            }
            return true;
        }

        static void MoveRacer(ref int location)
        {
            location++;
            Console.WriteLine($"{Thread.CurrentThread.Name} location={location}");
            if (location >= 100)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is the winner");
                return;
            }
        }
    }
}