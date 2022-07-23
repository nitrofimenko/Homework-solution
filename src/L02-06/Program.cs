using L02_06;

const double USD_RATE= 29.52467, EUR_RATE = 29.61973943, RUB_RATE = 0.5053433659;
Converter convert = new Converter(1 / USD_RATE, 1 / EUR_RATE, 1 / RUB_RATE);
Random random = new Random();
decimal sum = decimal.Round(decimal.Multiply((decimal)random.NextDouble(), random.Next()), 2);
Console.WriteLine($"{sum:# ### ### ##0.00} UAH = {convert.UAH2USD(sum):# ### ### ##0.00} USD \t {sum:# ### ### ##0.00} USD = {convert.USD2UAH(sum):# ### ### ##0.00} UAH");
Console.WriteLine($"{sum:# ### ### ##0.00} UAH = {convert.UAH2EUR(sum):# ### ### ##0.00} EUR \t {sum:# ### ### ##0.00} EUR = {convert.EUR2UAH(sum):# ### ### ##0.00} UAH");
Console.WriteLine($"{sum:# ### ### ##0.00} UAH = {convert.UAH2RUB(sum):# ### ### ##0.00} RUB \t {sum:# ### ### ##0.00} RUB = {convert.RUB2UAH(sum):# ### ### ##0.00} UAH");
