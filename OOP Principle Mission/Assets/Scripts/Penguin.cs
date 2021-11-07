using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : Bird
{
    public Penguin(string birdName) : base()
    {
        Debug.Log("Inheritance, Constructor");
        animalName = birdName;
    }

    public override bool CanFly()
    {
        Debug.Log("Abstraction, Polymorphism, CanFly()");
        return false;
    }

    public override void MakeSound()
    {
        Debug.Log("Abstraction, Polymorphism, MakeSound()");
        Debug.Log("Penguin Noise");
    }
}
