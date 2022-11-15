using System;
using System.Collections.Generic;

namespace Labb_4_Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee
            {
                ID = 1,
                Name = "Thomas Larsson",
                Gender = "Male",
                Salary = 20000
            };

            Employee E2 = new Employee
            {
                ID = 2,
                Name = "Johan Olofsson",
                Gender = "Male",
                Salary = 25000
            };

            Employee E3 = new Employee
            {
                ID = 3,
                Name = "Clara Olofsson",
                Gender = "Female",
                Salary = 28000
            };

            Employee E4 = new Employee
            {
                ID = 4,
                Name = "Clas Olsson",
                Gender = "Male",
                Salary = 28000
            };

            Employee E5 = new Employee
            {
                ID = 4,
                Name = "Jennifer Nilsson",
                Gender = "Female",
                Salary = 80800
            };

            //Stack
            Stack<Employee> stEmp = new Stack<Employee>();

            //Add items to the stack
            stEmp.Push(E1);
            stEmp.Push(E2);
            stEmp.Push(E3);
            stEmp.Push(E4);

            //Print all stacks
            Console.WriteLine("Print all stack");
            foreach (Employee item in stEmp)
            {
                Console.WriteLine("ID = {0} \nName = {1}\nGender = {2}\nSalary = {3}", item.ID, item.Name, item.Gender, item.Salary);
                Console.WriteLine("Item left in stack " + stEmp.Count);
                Console.WriteLine("-----------------------");


            }

            //Delete items from stack Pop one at a time
            Console.WriteLine("--------------POP--------------");
            for (int i = stEmp.Count; i > 0; i--)
            {
                Employee DelEmp = stEmp.Pop();
                Console.WriteLine("ID = {0} \nName = {1}\nGender = {2}\nSalary = {3}", DelEmp.ID, DelEmp.Name, DelEmp.Gender, DelEmp.Salary);
                Console.WriteLine("Item left in stack " + stEmp.Count);
                Console.WriteLine("-----------------------");

            }

            //Add items to the stack again
            Console.WriteLine("Restack");
            stEmp.Push(E1);
            stEmp.Push(E2);
            stEmp.Push(E3);
            stEmp.Push(E4);

            //Peek can only Peek info
            Console.WriteLine("----- Peek ----");
            Employee pE = stEmp.Peek();
            Console.WriteLine("ID: " + pE.ID + "\nName: " + pE.Name);
            Console.WriteLine("Item left in stack {0}", stEmp.Count);


            //Remove top item from stack
            Console.WriteLine("--------------POP--------------");
            Employee DelEmp1 = stEmp.Pop();
            Console.WriteLine("ID = {0} \nName = {1}\nGender = {2}\nSalary = {3}", DelEmp1.ID, DelEmp1.Name, DelEmp1.Gender, DelEmp1.Salary);
            Console.WriteLine("Item left in stack {0}", stEmp.Count);


            //Contain
            Console.WriteLine("-----------Contain------------");
            Console.WriteLine("See if ID Number 3 is in the stack");
            if (stEmp.Contains(E3))
            {
                Console.WriteLine("The item number 3 is in the stack");
            }
            else
            {
                Console.WriteLine("The item number 3 is not the stack");
            }

            //List
            Console.WriteLine("------Making List-----");
            List<Employee> listEmp = new List<Employee>();
            listEmp.Add(E1);
            listEmp.Add(E2);
            listEmp.Add(E3);
            listEmp.Add(E4);
            listEmp.Add(E5);

            //List Contain
            Console.WriteLine("List Contain");
            if (listEmp.Contains(E5))
            {
                Console.WriteLine("Employee nr 5 exist in the list");
            }
            else
            {
                Console.WriteLine("Employee nr 5 is not in the list");
            }


            Console.WriteLine("------FindFirstMale------");
            Employee findGender = listEmp.Find(G => G.Gender == "Male");

            Console.WriteLine("ID = {0} \nName = {1}\nGenger = {2} \nSalary = {3}", findGender.ID, findGender.Name, findGender.Gender, findGender.Salary);

            Console.WriteLine("------FindAllMale------");
            List<Employee> findAllGender = listEmp.FindAll(G => G.Gender == "Male");

            foreach (Employee item in findAllGender)
            {
                Console.WriteLine("ID = {0} \nName = {1}\nGenger = {2} \nSalary = {3}", item.ID, item.Name, item.Gender, item.Salary);

            }




        }
    }
}
