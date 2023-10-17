using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShunanovKE.Sprint1.TaskReview.V3.Lib
{
    public class DataService : ISprint1Task7V3
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((3 + Math.Exp(y - 1)) / (1 + x * x * Math.Abs(y - Math.Tan(x))), 3);
        }
    }
}
