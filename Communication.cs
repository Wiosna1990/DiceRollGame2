using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame2
{
    public class Communication
    {
        public string GetValue(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
