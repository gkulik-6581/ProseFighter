using System;

namespace ProseFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Find way to use ToUpper for inputs
            //TODO Better implementation of NPC class?
            //TODO Create 3 unique fighters to choose from
            //TODO Add power meter that fills for super move. Meter is filled after 3 consecutive hits. Does extra damage. Fighters might need more hit points
            //TODO Add dodge or defend to heal HP
            //TODO Create class or interface for combat?

            string userMoveString;
            //int userMoveInt;

            Console.WriteLine("Welcome to Prose Fighter!\nPlease enter your name.");

            Human h = new Human(Console.ReadLine(), 5, 0);
            NPC c = new NPC("Computo", 5, 0);

            Console.WriteLine($"{h.Name} you are about to challenge Computo, the worlds first figthing computer.\nThe controls are simple. Press a command followed by ENTER.\n" +
                $"\nP = Punch\nH = High Kick\nL = Low Kick\n\nAre you ready to fight {h.Name}?!\nEnter Y or N");

            string cont = Console.ReadLine();

            if (cont == "N")
            {
                Console.WriteLine($"Goodbye, {h.Name}.");
            }
            else
            {
                Console.WriteLine($"\nGet ready {h.Name}!\nFIGHT!!!");
            }


            //Combat


                while (h.HitPoints > 0 && c.HitPoints > 0)
            {
                userMoveString = Console.ReadLine();

                //Converts user input to int
                if (userMoveString == "M")
                {
                    Console.WriteLine("P = Punch\nH = High Kick\nL = Low Kick\n\nMake your move!\n");
                    userMoveString = Console.ReadLine();
                }
                else if (userMoveString == "H")
                {
                    h.Move = 3;
                }
                else if (userMoveString == "P")
                {
                    h.Move = 2;
                }
                else if(userMoveString == "L")
                {
                    h.Move = 1;
                }
                else
                {
                    h.Move = 0;
                }

                //NPC move, should fix to use NPC class
                Random r = new Random();
                int computoMove = r.Next(1, 4);

                //INVALID MOVE
                if (h.Move == computoMove)
                {
                    Console.WriteLine("You both miss. Keep fighting.");
                }

                //Human 3
                else if (h.Move == 3 && computoMove == 2)
                {
                    Console.WriteLine("You hit! Computo takes 1 point of damage!");
                    c.HitPoints -= 1;
                }
                else if(h.Move == 3 && computoMove == 1)
                {
                    Console.WriteLine("Computo hits you! You take 1 point of damage!");
                    h.HitPoints -= 1;
                }

                //Human 2
                else if(h.Move == 2 && computoMove == 1)
                {
                    Console.WriteLine("You hit! Computo takes 1 point of damage!");
                    c.HitPoints -= 1;
                }
                else if(h.Move == 2 && computoMove == 3)
                {
                    Console.WriteLine("Computo hits you! You take 1 point of damage!");
                    h.HitPoints -= 1;
                }

                //Human 1
                else if(h.Move == 1 && computoMove == 3)
                {
                    Console.WriteLine("You hit! Computo takes 1 point of damage!");
                    c.HitPoints -= 1;
                }
                else if(h.Move == 1 && computoMove == 2)
                {
                    Console.WriteLine("Computo hits you! You take 1 point of damage!");
                    h.HitPoints -= 1;
                }

                //TIE
                else
                {
                    Console.WriteLine("THAT'S NOT A VALID MOVE!!\nComputo hits you! You take 2 points of damage!");
                    h.HitPoints -= 2;
                }

                //End of round
                Console.WriteLine($"\n{h.Name} has {h.HitPoints}.\n{c.Name} has {c.HitPoints}.\n\nMake your next move.");
            }

            if (c.HitPoints == 0)
            {
                Console.WriteLine($"\n{c.Name} has lost all their hit points.\n{h.Name} wins!");
            }
            else
            {
                Console.WriteLine($"\n{h.Name} has lost all their hit points.\n{c.Name} wins!");
            }
        }
    }
}
