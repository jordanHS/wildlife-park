using System; 
using System.Collections.Generic;
using WildlifePark.Models;

namespace WildlifePark 
{
    public class Program  
    {
        public static void Main()
        {
        //   Animal One = new Animal("Red panda");
        //   Animal Two = new Animal("Python");
        //   Animal Three = new Animal("Tiger");
        //   //Animal Four = new Animal(userInput);

         // List<Animal> Animals = new List<Animal>() { One, Two, Three };

          Console.WriteLine("Write in your new type of Animal: ");
          string stringAnimalName = Console.ReadLine();
          string userAnimalNameInput = stringAnimalName; 
        //   Console.WriteLine("Write in your new Animal's Habitat : ");
        //   string stringAnimalHabitat = Console.ReadLine();

        //   string userAnimalHabitatInput = stringAnimalHabitat; 
          Console.WriteLine("Write in your new Animal's type of Habitat: ");
          string stringAnimalHabitat = Console.ReadLine();
          string userAnimalHabitatInput = stringAnimalHabitat; 
          
          Animal newAnimal = new Animal(userAnimalNameInput, userAnimalHabitatInput);
       
         
          
          //Animal newAnimal = new Animal(userInput.animalName);  
        //   Console.WriteLine(userInput);
          
                
          userAnimalNameInput = newAnimal.AnimalName;
        //   Console.WriteLine(Animal.PrintAnimal(userAnimalHabitatInput));
          userAnimalHabitatInput = newAnimal.AnimalHabitat;
          
         // Animal newAnimal = new Animal(userAnimalNameInput); userAnimalNameInput = newAnimal.AnimalName;
          Animal.PrintAnimal(userPrintAnimalInput);
          Console.WriteLine(Animal.PrintAnimal(userPrintAnimalInput));
          Animal.PrintHabitat(userPrintHabitatInput);
          Console.WriteLine(Animal.PrintHabitat(userPrintHabitatInput));
        }
    } 
}    