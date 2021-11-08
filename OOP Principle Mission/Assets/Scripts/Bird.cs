using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bird : Animal
{
    protected Bird()
    {
        isLiving = true;
    }

    public abstract string MakeSound();
    public abstract bool CanFly();
    public abstract string ReleaseBird();

    public string GetName()
    {
        return animalName;
    }

    public void Kill()
    {
        isLiving = false;
    }
    public string BirdStatus()
    {
        if(isLiving)
        {
            return BirdIsAlive();
        } else
        {
            return BirdIsDead();
        }
    }

    public string BirdIsDead()
    {
        return animalName + " is dead :(";
    }

    public string BirdIsAlive()
    {
        return animalName + " is alive :)";
    }
}
