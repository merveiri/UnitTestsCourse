using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsCourse
{
    public class WorldsDumbestFunction
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if(num == 0)
            {
                return "PIKACHU!";
            }
            else
            {
                return "Squirtle";
            }
        }

        public string testData(string info)
        {
            if(info == "test")
            {
                return "doğru data: " + info;
            } 
            else if(info == "deneme")
            {
                return "hatalı data";
            } else
            {
                return "Ben buradayım :)";
            }
           
          
        }
    }
}
