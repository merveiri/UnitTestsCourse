using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsCourse.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        //Naming Convention - ClassName_MethodName_ExepctedResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, you classes, go get functions
                int num = 0;

                string info = "test";
                
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                Console.WriteLine("ekrana test data bilgisini yaz: "+worldsDumbest.testData(info));
                
                //Act - Execute this function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);
                // Console.WriteLine("result: " + result);

                //Assert - Whatever ever is returned is it what you want
                if(result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
