using System.Collections;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace DutchTreat.Services {
    public class PracticeASP : IPracticeASP {


        public string optionalParameters(int i, int j, int k = 50) {

            
            var theNums = $"i = {i}, j = {j}, k = {k}";
            if (k == 50) { Console.WriteLine($"Default = {k}"); }
            else { Console.WriteLine($"The optional parameter was changed from the default of 50 to: {k}"); }
            return theNums;
        }


        //creating a generic
        public List<T> collectionOfThings<T, H>(T thing1, H thing2) {

            // practing string interpolation
            var thingsAsString = $"{thing1} + {thing2}";
            Console.WriteLine(thingsAsString);

            List<T> things = new List<T>();
            List<H> thingsOfH = new List<H>();


            things.Add(thing1);
            thingsOfH.Add(thing2);


            return things;
        }

        // using params
        public int Add(params int[] numbers) {
            int sum = 0;

            foreach(int number in numbers) {
                sum += number;
            }

            return sum;
        }

        // array practice
        public int arrayPrac() {

            // int array
            int[] numbers = new int[10];

            for (int i = 0; i < 9; i++) {
                numbers[i] = i * 10;
                Console.WriteLine(numbers);
            }

            return numbers[4];
        }
        
          
    }// end PracticeASP class
}
