using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01
{
    public class CalculatorScientific : Calculator
    {
        public double Pow(double number, double power) => Math.Pow(number, power);

        public double Percent(double number, double percent) => number * (percent / 100);

        public double Mod(double number) => Math.Abs(number);

        public double GetListSum(List<double> list) => list.Sum();

        public double GetListSum(double[] list) => list.Sum();

        public double GetMax(List<double> list) => list.Max();
    }
}
