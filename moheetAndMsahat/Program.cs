using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moheetAndMsahat
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of 'a' in cm:");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the value of 'b' in cm:");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the value of 'height' in cm:");
            float height = Convert.ToSingle(Console.ReadLine());

            float moheetCm = connect(a, b, height);
            float moheetM = moheetCm / 100;
            float moheetMm = moheetCm * 10;

            Console.WriteLine($"moheet = {moheetM} m");
            Console.WriteLine($"moheet = {moheetCm} cm");
            Console.WriteLine($"moheet = {moheetMm} mm\n");

            float masahatCm = masahat(a, b, height);
            float masahatM = masahatCm / 100;
            float masahatMm = masahatCm * 10;

            Console.WriteLine($"masahat = {masahatM} m");
            Console.WriteLine($"masahat = {masahatCm} cm");
            Console.WriteLine($"masahat = {masahatMm} mm");

            Console.ReadLine();
        }

        static float connect(float a, float b, float h)
        {
            return 2 * (2 * (2 * h + a) + b);
        }

        static float masahat(float a, float b, float h)
        {
            return 2 * (a * h) + 2 * (b * h) + 2 * (a + b);
        }
    }

}
