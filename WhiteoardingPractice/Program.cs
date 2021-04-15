using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteoardingPractice {
    class Program {
        static void Main(string[] args) {
            //var total = 0;
            //for (var idx = 1; idx < 51; idx++)
            //    if (idx % 7 == 0 || idx % 5 == 0) {
            //        total += idx;
            //    }
            //Console.WriteLine($"Total is {total}");
            //Console.ReadKey();


            // Fibonacci Series
            //int a = 1;
            //int b = 1;
            //int c = 0;
            //while (c <= 76) {
            //    c = a + b;
            //    a = b;
            //    b = c;
            // }


            var scores = new int[] { 4, 73, 67, 38, 33 };
            var rounded = new int[5];
            for (var idx = 0; idx < scores.Length; idx++) {
                rounded[idx] = scores[idx];
                if (scores[idx] < 38) continue;
                var inc = 0;
                while((scores[idx] + inc) % 5 != 0) {
                    inc++;
                }
                if(inc <= 2) {
                    rounded[idx] += inc;
                }
            }








        }
    }
}
