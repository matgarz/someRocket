using System;
using System.Threading;
using System.Media;

class RocketProgram
{
    static void Main()
    {
        Console.WriteLine("Initializing rocket...");
        Thread.Sleep(1000);

        Console.WriteLine("Rocket ready for launch!");
        Random random = new Random();
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"T-{i} seconds to launch...");
            Thread.Sleep(random.Next(500, 1500));
        }

        Console.WriteLine("Rocket launched!");
        PlaySound("rocket_launch.wav");
        for (int speed = 0; speed <= 100; speed += 10)
        {
            Console.WriteLine($"Rocket speed: {speed}%");
            Thread.Sleep(200);
        }

        Console.WriteLine("Rocket is now cruising...");
        Thread.Sleep(2000);

        Console.WriteLine("Rocket is now landing...");
        PlaySound("rocket_land.wav");
        for (int altitude = 10000; altitude >= 0; altitude -= 1000)
        {
            Console.WriteLine($"Altitude: {altitude} meters");
            Thread.Sleep(500);
        }

        Console.WriteLine("Rocket has landed safely!");
    }

    static void PlaySound(string soundFile)
    {
        using (SoundPlayer player = new SoundPlayer(soundFile))
        {
            player.PlaySync();
        }
    }
}
