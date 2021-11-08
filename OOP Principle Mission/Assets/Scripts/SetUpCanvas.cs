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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeBirdSound()
    {
        actions.text += Environment.NewLine + GameManager.instance.bird.MakeSound();
    }

    public void MakeBirdFly()
    {
        if(GameManager.instance.bird.CanFly())
        {
            actions.text += Environment.NewLine + "Flying";
        }
        else
        {
            actions.text += Environment.NewLine + "I Can't Fly!";
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
}
