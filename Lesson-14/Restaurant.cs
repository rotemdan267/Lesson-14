using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class Client
    {
        public void OrderPizza()
        {
            try
            {
                Chef.MakeDish("pizza");
            }
            catch (MessageToClientException mtc)
            {
                Console.WriteLine(mtc.Message);
            }

        }
        public void OrderChicken()
        {
            Chef.MakeDish("chicken");
        }
    }
    static class Chef
    {
        public static void MakeDish(string dish)
        {
            try
            {
                if (dish == "pizza")
                {
                    throw new NoPizzaException("we don't serve pizza");
                }
                else Console.WriteLine("Bon Appetit !!");
            }
            catch (NoPizzaException np)
            {
                Console.WriteLine(np.Message);
                // to log - ran out of cheese
                throw new MessageToClientException("But the chicken is great", np);
            }
        }
    }
}
