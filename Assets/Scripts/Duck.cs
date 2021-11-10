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
        if (isLiving)
        {
            Debug.Log("Abstraction, Polymorphism, CanFly()");
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string MakeSound()
    {
        if (isLiving)
        {
            Debug.Log("Abstraction, Polymorphism, MakeSound()");
            Debug.Log("QUACK!");

            return "Quack!";            
        }
        else
        {
            return BirdIsDead();
        }
    }

    public override string ReleaseBird()
    {
        string message = "";

        if (isLiving)
        {
            message = message + animalName + " Begins to fly away, " + MakeSound();
        }
        else
        {
            message = message + BirdIsDead();
        }

        return message;
    }


}
