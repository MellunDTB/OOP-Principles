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

    public override string MakeSound()
    {
        if (isLiving)
        {
            Debug.Log("Abstraction, Polymorphism, MakeSound()");
            Debug.Log("Penguin Noise");

            return "Penquin Noise";
        }
        else
        {
            return BirdIsDead();
        }
    }

    public override string ReleaseBird()
    {
        string message = "";

        if(isLiving)
        {
            message = message + animalName + " Begins to waddle away, " + MakeSound();
        } else
        {
            message = message + BirdIsDead();
        }

        return message;
    }
}
