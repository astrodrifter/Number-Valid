using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace NumberValid {
    class Program {
        static void Main(string[] args) {
            int[] number = new int[9];
            Console.Write("Enter your 9 digit number by pressing enter after each didgit:\n");
            for (int i = 0; i < 9; i++) {            
                number[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(NumberValid(number));
            Console.ReadKey();
        }
        /// <summary>
        /// Performs a modula-11 validation check on number
        /// </summary>
        /// <param name="number">a 9 digit positive integer</param>
        /// <returns> true if modula-11 check is successful 
        /// otherwise returns false </returns>
        static bool NumberValid(int[] number) {
            int sum = 0;
            bool modulo = false;
            for(int j = 0; j < number.Length; j++) {
                sum = sum + (number[j] * (9-j));               
            }            
            if (sum % 11 == 0) {
                modulo = true;
            }
            return modulo;          
        }
    }
}
