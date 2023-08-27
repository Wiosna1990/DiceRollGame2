using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame2
{
    public class Game
    {
        private Player _player = new Player();
        private Dice _dice = new Dice();
        public Game()
        {

        }
        public void Play()
        {
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
            var diceResult = _dice.Roll();
            int counter = 0;
            do
            {
                var playerAnswer = _player.Answer();

                if (!int.TryParse(playerAnswer, out int number))
                {
                    Console.WriteLine("Incorrect answer");
                }
                else
                {
                    counter++;
                    if (number == diceResult)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer!");
                    }

                }
            } while (counter<3);
        }
    }
}
