using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private string birdsName { get; set; }
    private int birdType { get; set; }

    public Bird bird;

    [SerializeField] private InputField birdsNameInput;
    [SerializeField] private Dropdown birdTypeDropDown;

    public static GameManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetBirdName()
    {
        birdsName = birdsNameInput.text;
    }

    public void SetBirdType()
    {
        birdType = birdTypeDropDown.value;
    }

    public void StartGame()
    {
        if(birdType == 0)
        {
            Debug.Log("Duck Created");
            bird = new Duck(birdsName);
        } else
        {
            Debug.Log("Penguin Created");
            bird = new Penguin(birdsName);
        }
    }
}
