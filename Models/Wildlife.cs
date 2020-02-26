using System;
using System.Collections.Generic;

namespace WildlifeZoo.Models {

    public class Animal
    {
        private string _animalType;
        private double _weight;
        private int _age;

    public Animal(string animalType, double weight, int age) 
    {
        _animalType = animalType;
        _weight = weight;
        _age = age;
    }

    public string GetAnimalType()
    {
        return _animalType;
    }

    public double GetAnimalWeight()
    {
        return _weight;
    }

    public int GetAnimalAge()
    {
        return _age;
    }
    
    }
}
