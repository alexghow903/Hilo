using System;

namespace hilo 
{
    public class Program
    {
        public int cards()
        {
            int card;
            Random rand = new Random();
            card = rand.Next(1, 14);
            return card;
        }

        public int horl(int card, int ncard)
        {
            Console.Write("Higher of lower? [h/l] ");
            string answer = Console.ReadLine();
            if (answer == "h")
            {
                if (card < ncard)
                {
                    return 100;
                }
                else
                {
                    return -75;
                }
            }
            else if (answer == "l")
            {
                if (card > ncard)
                {
                    return 100;
                }
                else
                {
                    return -75;
                }
            }
            else
            {
                return 0;
            }
        }
        public void control()
        {
            int points = 300;
            int card = cards();
            string answer;
            while (points > 0)
            {
                int ncard = cards();
                Console.WriteLine($"The card is: {card}");
                points = points + horl(card, ncard);
                Console.WriteLine($"Next card was: {ncard}");
                Console.WriteLine($"Your score is: {points}");
                card = ncard;
                if (points > 0)
                {
                    Console.WriteLine("Play again? [y/n]");
                    answer = Console.ReadLine();
                    if (answer == "n")
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Game Over");
        }
    }
}