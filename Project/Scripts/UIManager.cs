using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject instructionMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void Instructions()
    {
        instructionMenu.SetActive(true);
    }

    public void ExitInstructions()
    {
        instructionMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
