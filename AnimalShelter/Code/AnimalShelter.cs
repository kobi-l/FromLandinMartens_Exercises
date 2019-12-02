using AnimalShelter.Code.Enums;
using AnimalShelter.Code.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code
{
    public class AnimalShelter : IShelter
    {
        private readonly Dictionary<Guid, IAnimal> AnimalsList = new Dictionary<Guid, IAnimal>();
        public AnimalAddResult AddAnimal(IAnimal animal)
        {
            
            switch (animal.AnimalType)
            {
                case AnimalType.Cat:
                case AnimalType.Dog:
                case AnimalType.Bird:
                case AnimalType.Snake:
                    AnimalsList.Add(Guid.NewGuid(), animal);
                    return new AnimalAddResult(true, animal, "");
                default:
                    return new AnimalAddResult(false, null, "Animal is not a supported animal");
            } 
        }

        public void GetAnimals()
        {

        }

        public void RemoveAnimal()
        {

        }

        public void GetAnimalFromId()
        {

        }
    }
}
