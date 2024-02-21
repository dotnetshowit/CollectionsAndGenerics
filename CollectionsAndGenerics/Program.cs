using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

          
            
            int[] fixedArray = new int[5];

            fixedArray[0] = 4;
            fixedArray[1] = 2;
            fixedArray[2] = 5;
            fixedArray[3] = 1;
            fixedArray[4] = 3;


            for (int i = 0; i < fixedArray.Length; i++)
            {
                Console.WriteLine(fixedArray[i]);
            }

            Array.Sort(fixedArray);

            Array.Reverse(fixedArray);

            Console.WriteLine(fixedArray);

            foreach (int num in fixedArray)
            {
                Console.WriteLine(num);
            }


            string[] names = new string[2];

            names[0] = "A";
            names[1] = "B";


            // Jagged Array

            //int[,] jaggedArray = new int[3, 3];

            //jaggedArray[0, 0] = 1;
            //jaggedArray[1, 0] = 2;


            //  jaggedArray[0][0]    jaggedArray[0][1]    jaggedArray[0][2] 
            //  jaggedArray[1][0]    jaggedArray[1][1]    jaggedArray[1][2]
            //  jaggedArray[2][0]    jaggedArray[2][1]    jaggedArray[2][2] 




            int[,] jaggedArray = new int[3,4] { {1,2,3,5}, {4,5,6,5}, { 7, 8, 9, 5 } };
          

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray.GetLength(1); j++)
                {
                    Console.WriteLine(jaggedArray[i, j]);
                }
            }


            //ArrayList arrList = new ArrayList();
            //arrList.Add(1);
            //arrList.Add(2);
            //arrList.Add("DotNet");

            ArrayList arrList = new ArrayList()
            {
                1,2,"Dotnet"
            };


            arrList.Insert(0, "First Element");

            foreach(var elem in arrList)
            {
                Console.WriteLine(elem);
            }

            // First Element
            // 1
            // 2
            // Dotnet


            arrList.Remove(1);

            // First Element
            // 2
            // Dotnet

            arrList.Clear();




            List<int> intList = new List<int>();


            intList.Add(1);
            intList.Insert(0,3);
            intList.AddRange(new List<int>() { 1, 2, 3, 5 });

            
            List<Employee> employees = new List<Employee>();

            var employeeParth = new Employee();

            employeeParth.FirstName = "Parth";
            employeeParth.LastName = "Patel";
            employeeParth.CreatedAt = DateTime.Now;
            var parthCards = new List<Card>();
            parthCards.Add(new Card() { CardId = 1, CardName = "AXIS", CardNumber = "3242423423", CVV = 123 });
            parthCards.Add(new Card() { CardId = 2, CardName = "SBI", CardNumber = "72453243", CVV = 456});

            employeeParth.Cards = parthCards;


        //{
        //    employeeParth:
        //    {
        //        FirstName: "",
        //        LastName: "",
        //        Cards: [
        //            { 
        //                CardId: ""
        //                CardName: ""            
        //            { 
        //                CardId: ""
        //                  CardName: ""
            //            }
            //            ]
            //    }
            //}


            //employees.Add(new Employee() { FirstName = "A", LastName = "B", Cards = new List<Card>() { new Card() { } } });
            //employees.Add(new Employee() { FirstName = "B", LastName = "B" });
            //employees.Add(new Employee() { FirstName = "N", LastName = "Y" });
            //employees.Add(new Employee() { FirstName = "T", LastName = "O" });
            //employees.Add(new Employee() { FirstName = "U", LastName = "B" });


            foreach (var item in employees)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            // List Of Countries

            //  ID CountryCode CountryName


            Dictionary<string,Employee> emp = new Dictionary<string, Employee>();

            emp.Add("TGAASDZCVX", employeeParth);
          

            Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);

            //ints.Dequeue();
            //ints.Dequeue();



            // 2, 3
            // 3
            Stack<int> intStack= new Stack<int>();
            intStack.Push(5);
            intStack.Push(4);
            intStack.Push(3);
            intStack.Push(2);
            intStack.Push(1);


            intStack.Pop();

            // 2,3,4,5


            GenericCalculator<int> genInt = new GenericCalculator<int>();

            genInt.Print(1, 2);



            GenericCalculator<float> genFloat = new GenericCalculator<float>();
            genFloat.Print(1.2f, 2.4f);


            GenericRepository<Employee> repoEmp = new GenericRepository<Employee>();
            repoEmp.Add(new Employee() { FirstName = "Tushar", LastName = "Patel" });

            GenericRepository<Country> repoCountry = new GenericRepository<Country>();
            repoCountry.Add(new Country() { });
            
            GenericRepository<Person> repoPerson = new GenericRepository<Person>();
            var parth = new Person();
            var tushar = new Person();

            repoPerson.Add(parth);
            repoPerson.Add(tushar);


            //  School, Techers, Studemt, Standard, Exam

            // School - CRUD
            // Techers - CRUD













            Console.ReadLine();



        }
    }
}
