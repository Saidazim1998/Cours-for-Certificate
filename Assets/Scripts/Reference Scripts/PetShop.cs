using UnityEngine;
using System;

public class PetShop : MonoBehaviour
{
    [SerializeReference] 
    public Mammal mammal = new Cat(); // To‘liq polimorfizm
}

public class Animal {}

[Serializable]
public class Mammal : Animal
{
    public string species = "Unknown";
}

[Serializable]
public class Cat : Mammal
{
    public int lives = 9; // Cat sinfiga xos xususiyat
}