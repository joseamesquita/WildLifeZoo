using System;
using System.Collections.Generic;
using WildlifeZoo.Models;

namespace WildlifeZoo {
    
    public class Program
    {
        public static void Main()
        {   
        Animal tiger = new Animal("Tiger", 120.32, 11);
        
        List<Animal> Zoo = new List<Animal>() { tiger };

        Console.WriteLine("Do you want to add an animal? y for yes, enter for no");
           
           string addAnswer = Console.ReadLine();
            if (addAnswer == "y" || addAnswer == "Y") {

        Console.WriteLine("Enter Animal Type: ");
            string animalTypeAnswer = Console.ReadLine();
        Console.WriteLine("Enter Animal Weight (decimals): ");
            string stringAnimalWeightAnswer = Console.ReadLine();
            double animalWeightAnswer = double.Parse(stringAnimalWeightAnswer);
        Console.WriteLine("Enter Animal Age: ");
            string stringAnimalAgeAnswer = Console.ReadLine();
            int animalAgeAnswer = int.Parse(stringAnimalAgeAnswer);

        Zoo.Add(new Animal(animalTypeAnswer, animalWeightAnswer, animalAgeAnswer));

            } 

        Console.WriteLine("Do you want to view all the animals at the zoo? y for yes, enter for no");

       string viewAnswer = Console.ReadLine();
       if (viewAnswer == "y" || viewAnswer == "Y")
        {
            foreach(Animal creature in Zoo)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Animal Type: " + creature.GetAnimalType());
            Console.WriteLine("Animal Weight: " + creature.GetAnimalWeight());
            Console.WriteLine("Animal Age: " + creature.GetAnimalAge());
        }
      }

        Console.WriteLine("Are you done with the zoo viewer? y for yes, enter for no");
           if (doneAnswer == "y" || doneAnswer == "Y")
           {
               Console.WriteLine("bai");
           } else {
               Main();
           }



        }
    }
}