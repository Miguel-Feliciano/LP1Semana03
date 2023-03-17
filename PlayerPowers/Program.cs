using System;

namespace PlayerPowers
{
    enum Power
    {
        None = 0,
        Fly = 1,
        XRayVision = 2,
        SuperStrength = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of players: ");
            int n = int.Parse(Console.ReadLine());

            Power[][] playerPowers = new Power[n][];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the powers of player {i + 1}:");
                playerPowers[i] = new Power[3];

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Power {j + 1} | 0: None | 1: Fly | 2: XRayVision | 3: SuperStrength | : ");
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            playerPowers[i][j] = Power.Fly;
                            break;
                        case 2:
                            playerPowers[i][j] = Power.XRayVision;
                            break;
                        case 3:
                            playerPowers[i][j] = Power.SuperStrength;
                            break;
                        default:
                            playerPowers[i][j] = Power.None;
                            break;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Powers of player {i + 1}: ");

                for (int j = 0; j < 3; j++)
                {
                    if (playerPowers[i][j] != Power.None)
                    {
                        Console.Write($"| {playerPowers[i][j]} |");
                    }
                }
                Console.WriteLine("\n ");

                if (Array.Exists(playerPowers[i], p => p == Power.Fly) && Array.Exists(playerPowers[i], p => p == Power.SuperStrength))
                {
                    Console.WriteLine("Flying radiation!");
                }

                Console.WriteLine();
            }
        }
    }
}

