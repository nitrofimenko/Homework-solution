using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_06
{
    internal class Converter
    {
        double usd, eur, rub;
        public Converter(double usdFromUser, double eurFromUser, double rubFromUser)
        {
            usd = usdFromUser;
            eur = eurFromUser;
            rub = rubFromUser;
        }
        public decimal USD2UAH(decimal sum) => decimal.Round(decimal.Divide(sum, (decimal)usd), 2);
        public decimal EUR2UAH(decimal sum) => decimal.Round(decimal.Divide(sum, (decimal)eur), 2);
        public decimal RUB2UAH(decimal sum) => decimal.Round(decimal.Divide(sum, (decimal)rub), 2);
        public decimal UAH2USD(decimal sum) => decimal.Round(decimal.Multiply(sum, (decimal)usd), 2);
        public decimal UAH2EUR(decimal sum) => decimal.Round(decimal.Multiply(sum, (decimal)eur), 2);
        public decimal UAH2RUB(decimal sum) => decimal.Round(decimal.Multiply(sum, (decimal)rub), 2);
    }
}
