using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bird : Animal
{
    protected Bird()
    {
        isLiving = true;
    }

    public abstract void MakeSound();
    public abstract bool CanFly();

    public string GetName()
    {
        return animalName;
    }

    public bool IsAlive()
    {
        return isLiving;
    }

    public void Kill()
    {
        isLiving = false;
    }
}
