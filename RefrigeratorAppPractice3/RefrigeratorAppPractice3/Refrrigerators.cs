using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrrigerators
    {
        public double MaxWeight { set; get; }
        public double currentWeight;
        public double remainingWeight;

        public double Weight(int item, double unitWeight)
        {
            currentWeight = Convert.ToDouble(item) * unitWeight;

            

            return currentWeight;

        }
    }
}
