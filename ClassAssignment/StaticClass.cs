using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public static class StaticClass
    {
        public static string favoriteAnimal(string animal)
        {
            if (animal == "Norwegian Forest Cat")
            {
                string response = "Me too! You're cool!";
                return response;
            }
            else
            {
                string response = animal + "s are lame.";
                return response;
            }
        }
    }
}
