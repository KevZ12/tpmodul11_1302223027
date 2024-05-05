// See https://aka.ms/new-console-template for more information
using AljabarLibraries;
double[] persamaan1 = new double[] { 1,-3,-10} ;
double[] persamaan2 = new double[] { 2,-3} ;
Aljabar aljabar = new Aljabar();






Console.WriteLine($"Akar persamaan kuadrat dari {persamaan1[0]}x^2" +
                          $"{(persamaan1[1] >= 0 ? "+" : "")}{persamaan1[1]}x" +
                          $"{(persamaan1[2] >= 0 ? "+" : "")}{persamaan1[2]} adalah x1 = {aljabar.AkarPersamaanKuadrat(persamaan1)[0]} " +
                          $"dan x2 = {aljabar.AkarPersamaanKuadrat(persamaan1)[1]}");


Console.WriteLine($"Hasil persamaan kuadrat dari a = {persamaan2[0]} dan b = {persamaan2[1]} adalah: {aljabar.hasilKuadrat(persamaan2)[0]}x^2" +
                          $"{(aljabar.hasilKuadrat(persamaan2)[1] >= 0 ? "+" : "")}{aljabar.hasilKuadrat(persamaan2)[1]}x" +
                          $"{(aljabar.hasilKuadrat(persamaan2)[2] >= 0 ? "+" : "")}{aljabar.hasilKuadrat(persamaan2)[2]}");