using System;


namespace Assessment{
    class Program{
        static void Main(string[] args){
            Console.Clear();

            // Array();
            // ListTask();
            // DictionaryTask();
        

        // static void Array(){

            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            foreach(int num in numArray){
                Console.Write($"{num}, ");
            } //foreach numArray

            Console.WriteLine("");
            Console.WriteLine("=======");

            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            foreach(string name in nameArray){
                Console.Write($"{name}, ");
            }//foreach nameArray

            Console.WriteLine("");
            Console.WriteLine("=======");

            int[] boolArray = {1,2,3,4,5,6,7,8,9,10};
            int boolArrayCount = 0;
            while (boolArrayCount < 10){
            
            foreach(int b in boolArray){
                if(b % 2 == 0){
                    Console.WriteLine($"{b}: False");
                    boolArrayCount++;
                }else if(b % 2 != 0){
                    Console.WriteLine($"{b}: True");
                    boolArrayCount++;
                }
            }//foreach boolArray
            }//while boolArray
            Console.ReadKey();
        // }//Array 

        // static void  ListTask(){
            List<string> flavors = new List<string>();
            flavors.Add("Butter Pecan");
            flavors.Add("Chocolate Chip Cookie Dough");
            flavors.Add("Boonilla");
            flavors.Add("Strawberry");
            flavors.Add("Cookies and Cream");

            Console.WriteLine("Welcome to DigiCream!");
            Console.WriteLine("\nOur flavors are: ");
            foreach(string flavor in flavors){
                Console.Write($"{flavor}, ");
            }
            Console.WriteLine("\n");

            Console.WriteLine($"\nThe third flavor is {flavors[2]}!");

            flavors.RemoveAt(2);

            Console.WriteLine($"\nOne flavor just sold out. We have these flavors left:");
            foreach(string flavor in flavors){
                Console.Write($"{flavor}, ");
            }
            Console.ReadKey();
        // }//ListTask

        // static void DictionaryTask(){
            Console.WriteLine("\n");
            Dictionary<string, string> creamLovers = new Dictionary<string, string>();

            creamLovers.Add(nameArray[0], flavors[1]);
            creamLovers.Add(nameArray[1], flavors[3]);
            creamLovers.Add(nameArray[2], flavors[2]);
            creamLovers.Add(nameArray[3], flavors[0]);
            
            foreach(KeyValuePair<string, string>creamLover in creamLovers){
                // Console.WriteLine("{0} likes {1} flavor.", kvp.Key, kvp.Value);
                Console.WriteLine($"{creamLover.Key} likes {creamLover.Value} flavor.");
            }


        // }//DictionaryTask
        }//Main
    }//class Program
}// namespace Assessment