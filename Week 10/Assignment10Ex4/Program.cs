using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Assignment10Ex4
{
    internal class Alarm { }
    internal class Teeth { }
    internal class Shower { }
    internal class Dress { }
    internal class Drive { }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                TurnOffAlarm();
                Console.WriteLine("Out of bed and ready to go");

                BrushTeeth();
                Console.WriteLine("Teeth are clean");

                // Shower shower = await TakeAShowerAsync();
                // Console.WriteLine("Showering is done");

                GetDressed();
                Console.WriteLine("Dressed and ready to go");

                // Drive drive = await DriveToWorkAsync(10);
                // Console.WriteLine("Walking into work.");

                Console.WriteLine("Ready to begin");
                sw.Stop();
                Console.WriteLine("The program took " + sw.ElapsedMilliseconds + " milliseconds to run");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"An exception has occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TurnOffAlarm()
        {
            Console.WriteLine("Turned off alarm");
            return;
        }

        private static void BrushTeeth() => Console.WriteLine("Putting paste on the brush... Brushing");

        // private static async Task<Shower> TakeAShowerAsync()
        // {
        //     Console.WriteLine("Warming the water...");
        //     await Task.Delay(1000);
        //     Console.WriteLine($"Shampoo and Condition the hair");
        //     Console.WriteLine("Rinse off");
        //     await Task.Delay(2000);
        //     Console.WriteLine("Dry off");
        //     return new Shower();
        // }

        private static void GetDressed() => Console.WriteLine("Together and ready to go");

        // private static async Task<Drive> DriveToWorkAsync(int time)
        // {
        //     Console.WriteLine("Starting the car...");
        //     for (int i = 0; i < time; i++)
        //     {
        //         Console.WriteLine($"Driving...");
        //     }
        //     await Task.Delay(1000);
        //     Console.WriteLine("Arrived at work");
        //     return new Drive();
        // }
    }
}