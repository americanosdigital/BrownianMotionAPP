using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrownianMotionAPP.Models
{
    public class BrownianMotionModel
    {
        public static double[] GenerateBrownianMotion(double initialPrice, double volatility, double meanReturn, double time, int steps = 1000)
        {
            var prices = new double[steps];
            prices[0] = initialPrice;
            var random = new Random();

            for (int i = 1; i < steps; i++)
            {
                double dt = time / steps;
                double dw = Math.Sqrt(dt) * random.NextDouble();
                prices[i] = prices[i - 1] * Math.Exp((meanReturn - 0.5 * Math.Pow(volatility, 2)) * dt + volatility * dw);
            }

            return prices;
        }
    }
}
