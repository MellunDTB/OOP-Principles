using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Bird
{
    public Duck(string birdName) : base()
    {
        animalName = birdName;
    }

    public override bool CanFly()
    {
        Debug.Log("Abstraction, Polymorphism, CanFly()");
        return true;
    }

    public override void MakeSound()
    {
        Debug.Log("Abstraction, Polymorphism, MakeSound()");
        Debug.Log("QUACK!");
    }
}
