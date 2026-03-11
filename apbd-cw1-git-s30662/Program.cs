// See https://aka.ms/new-console-template for more information
double[] wektor1 = { 5, 10, 4, 2, 3 };
double[] wektor2 = { 5, 10, 4, 2, 3 };
Console.WriteLine(DodajWektory(wektor1,wektor2));
double[] DodajWektory(double[] wektor1, double[] wektor2)
{
    int a = wektor1.Length > wektor2.Length ? wektor1.Length : wektor2.Length;
   double[] result = new double[a];
   for (int i = 0; i < a; i++)
   {
       if(wektor1.Length > a && wektor2.Length > a)
      result[i] = wektor1[i] + wektor2[i];
   }
   return result;
}

double[] OdejmijWektory(double[] wektor1, double[] wektor2)
{
    int a = wektor1.Length > wektor2.Length ? wektor1.Length : wektor2.Length;
    double[] result = new double[a];
    for (int i = 0; i < a; i++)
    {
        if(wektor1.Length > a && wektor2.Length > a)
        result[i] = wektor1[i] - wektor2[i];
    }
    return result;
}