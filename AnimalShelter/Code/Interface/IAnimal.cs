using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code.Interface
{
    public interface IAnimal
    {
        Guid? AnimalId { get; set; }
        AnimalType AnimalType { get; }
    }
}
