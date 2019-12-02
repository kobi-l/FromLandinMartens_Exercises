using AnimalShelter.Code.Enums;
using AnimalShelter.Code.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code
{
    public class Animal : IAnimal

    {
        public Guid? AnimalId { get; set; }
        public AnimalType AnimalType { get; }

        public Animal(AnimalType animalType)
        {
            AnimalType = animalType;
        }
    }
}
