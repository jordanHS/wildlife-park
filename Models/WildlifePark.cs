using System; 

namespace WildlifePark.Models
{
    class Animal
    {
        public string AnimalName { get; private set; }
        public string AnimalHabitat { get; private set; }
        
        public Animal (string animalName, string animalHabitat)
        {
            AnimalName = animalName;
            AnimalHabitat = animalHabitat;
        }
        public static string PrintAnimal(string userAnimalNameInput)
        {
        return "Our Animals " + userAnimalNameInput; //Console.WriteLine(Animal.PrintAnimal(userInput));
        }
    
        public static string PrintHabitat(string userAnimalHabitatInput)
        {
        return "Our Habitat " + userAnimalHabitatInput; 
        }
    
    }

    
} 
