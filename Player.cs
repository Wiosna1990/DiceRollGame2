using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame2
{
    public class Player
    {
        Communication communication = new Communication();
        public string Answer()
        {
            return communication.GetValue("Enter a number");
        }
    }
}
