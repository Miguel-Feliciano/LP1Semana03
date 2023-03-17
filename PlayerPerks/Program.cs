using System;

namespace PlayerPerks
{
        [Flags]
    enum Perks
    {
        WaterBreathing = 1,
        Stealth = 2,
        AutoHeal = 4,
        DoubleJump = 8
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No perks at all!");
                return;
            }

            Perks playerPerks = 0;

            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'w':
                        playerPerks ^= Perks.WaterBreathing;
                        break;
                    case 'a':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 's':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown perk!");
                        return;
                }
            }

            Console.WriteLine("Player perks: " + playerPerks);

            if ((playerPerks & Perks.Stealth) == Perks.Stealth && (playerPerks & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((playerPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}

