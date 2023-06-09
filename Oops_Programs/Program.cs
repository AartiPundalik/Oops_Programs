﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Oops_Programs.Person;

namespace Oops_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Types Of Inheritance
            Stationary stationary = new Stationary();
            stationary.NoteBook();
            Pen pen = new Pen();
            pen.BluePen();
            CraftPaper craftpaper = new CraftPaper();
            craftpaper.VerticleCraftPaper();
            WritingMaterial material = new Envelops();
            material.Classmate();

            // Class And Object
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.insert(65, "Aarti", 800000f);
            e2.insert(66, "Sangita", 400000f);
            e1.display();
            e2.display();
            Console.ReadLine();

            // Inheritance
            Truck truck = new Truck();
            truck.EngineNo();
            Console.WriteLine(truck.brand + " " + truck.modelName);
            Console.ReadLine();

            // Polymorphism
            Polymorphism polymorphismflower = new Polymorphism();
            polymorphismflower.FlowerSmells();
            Polymorphism flowerLily = new Lily();
            flowerLily.FlowerSmells();
            Polymorphism flowerJasmine = new Jasmine();
            flowerJasmine.FlowerSmells();
            Console.ReadLine();
            // Method Overloading
            IntergerNumber intergerNumber = new IntergerNumber();
            intergerNumber.TotalSum(5, 7);
            intergerNumber.TotalSum(53, 8);
            Console.ReadLine();
            // Method Overriding
            Polygon polygon = new Polygon();
            polygon.render();
            polygon = new Square();
            polygon.render();
            Console.ReadLine();

            // Encapsulation
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Name = "Aarti Pundalik";
            encapsulation.Age = 22;
            Console.WriteLine(" Name : " + encapsulation.Name);
            Console.WriteLine(" Age : " + encapsulation.Age);
            Console.ReadLine();

            // Abstraction
            Creta creta = new Creta();
            creta.CarModel();
            creta.ModelNo();
            Console.ReadLine();

            // Types Of Variables
            // Local Variable
            TypesOfVariables typesofVariables = new TypesOfVariables();
            typesofVariables.PersonAge();
            Console.ReadLine();
            // Instance Variable
            Person person = new Person("Aarti", 22);
            person.Hello();
            Console.ReadLine();
            // Static Variable
            StaticExample.StaticVariable();
            StaticExample.StaticVariable();
            StaticExample.StaticVariable();
            Console.ReadLine();
            // Constant Variable
            const double pi = 2.34567;
            double radius = 4.0;
            double area = pi * radius * radius;
            Console.WriteLine("The area of a circle with radius {0} is {1}", radius, area);
            Console.ReadLine();
            // Read - Only Variable
            string message = "Hello, Everyone";
            Console.WriteLine(message);
            Console.ReadLine();



        }
    }

}






    



    
    
    


    

    
    
    

