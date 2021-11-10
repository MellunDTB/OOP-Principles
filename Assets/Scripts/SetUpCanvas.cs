using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetUpCanvas : MonoBehaviour
{
    public Text birdNameDisplay;
    public Text actions;

    // Start is called before the first frame update
    void Start()
    {
        birdNameDisplay.text = GameManager.instance.bird.GetName();
    }

    public void MakeBirdSound()
    {
        actions.text += Environment.NewLine + GameManager.instance.bird.MakeSound();
    }

    public void MakeBirdFly()
    {
        if(GameManager.instance.bird.CanFly() && GameManager.instance.bird.isLiving)
        {
            actions.text += Environment.NewLine + "Flying";
        }
        else if(!GameManager.instance.bird.CanFly() && GameManager.instance.bird.isLiving)
        {
            actions.text += Environment.NewLine + "I Can't Fly!";
        }
        else
        {
            actions.text += Environment.NewLine + GameManager.instance.bird.BirdIsDead();
        }
        
    }
    public void ReleaseBird()
    {
        actions.text += Environment.NewLine + GameManager.instance.bird.ReleaseBird();
    }

    public void KillBird()
    {
        GameManager.instance.bird.Kill();
    }

    public void GoBack()
    {
        Destroy(GameManager.instance.gameObject);
        SceneManager.LoadScene(0);
    }
}
