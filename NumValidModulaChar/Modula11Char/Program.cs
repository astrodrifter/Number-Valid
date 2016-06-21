using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modula11Char {
    class Program {
        static void Main(string[] args) {

            // input number
            //var myString = "374839018";
            Console.Write("Enter your 9 digit positive intger number: ");
            var myString = Console.ReadLine();

            // Convert ToCharArray
            var charArray = myString.ToCharArray();

            // Convert tp byteArray
            byte[] byteArray = myString.ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();

            // Print to console to check
            for(int i = 0; i < byteArray.Length; i++) {
                Console.WriteLine(byteArray[i]);
            }
            bool valid = NumberValid(byteArray);
            Console.WriteLine(valid);
            Console.ReadKey();

        }
        /// <summary>
        /// Performs a modula-11 validation check on number
        /// </summary>
        /// <param name="array">a 9 digit positive integer</param>
        /// <returns> true if modula-11 check is successful 
        /// otherwise returns false </returns>
        static bool NumberValid(byte[] array) {
            int sum = 0;
            bool modula = false;
            for (int j = 0; j < array.Length; j++) {
                sum = sum + (array[j] * (9 - j));
            }
            if (sum % 11 == 0) {
                modula = true;
            }
            return modula;
        }
    }
}
