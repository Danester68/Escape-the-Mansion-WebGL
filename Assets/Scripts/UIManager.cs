using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject instructionMenu;
    private String levelName;
    public String level1Name;
    public String level2Name;
    public TMP_Dropdown levelDropdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (levelDropdown.value)
        {
            case 0:
                levelName = level1Name;
                break;
            case 1:
                levelName = level2Name;
                break;
        }
    }

    public void Play()
    {
        SceneManager.LoadSceneAsync(levelName);
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
