namespace AljabarLibraries
{
    public class Aljabar
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan) {
            double[] result = new double[2];
            double a = persamaan[0];
            double b = persamaan[1];    
            double c = persamaan[2];

            double akarDeterminan = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

            double x = (-b+ akarDeterminan)/2*a;
            result[0] = x;
            x = (-b - akarDeterminan) / 2 * a;
            result[1] = x;


            return result;

        }

        public double[] hasilKuadrat(double[] persamaan)
        {
            double[] result = new double[3];
            double a = persamaan[0];
            double b = persamaan[1];
            double x = Math.Pow(a,2);
            result[0] = x;
            x = 2*a*b;
            result[1] = x;
            x = Math.Pow(b, 2);
            result[2] = x;


            return result;
            
        }

    }
}