using AnimalShelter.Code.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code
{
    public class AnimalAddResult
    {
        public bool AnimalWasAdded { get; }
        public IAnimal AnimalObject { get; }
        public string ErrorMessage { get; }

        public AnimalAddResult(bool animalWasAdded, IAnimal animalObject, string errorMessage)
        {
            AnimalWasAdded = animalWasAdded;
            AnimalObject = animalObject;
            ErrorMessage = errorMessage;
        }
    }
}
