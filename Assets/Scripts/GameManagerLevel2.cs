using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerLevel2 : MonoBehaviour
{
    public GameObject finishUI;

    private bool isFinished;

    public LightScript lightScript;

    public String nextLevelName;
    // Start is called before the first frame update
    void Start()
    {
        isFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFinished && Input.GetKeyDown(KeyCode.Return)) 
        {
            SceneManager.LoadSceneAsync(nextLevelName);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadSceneAsync("Menu");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "FinishObject":
                finishGame();
                break;
            case "LightSwitch1" or "LightSwitch2" or "LightSwitch3":
                lightScript.ToggleLight(collision.gameObject.tag);
                break;
        }
    }
    void finishGame()
    {
        isFinished = true;
        finishUI.SetActive(true);
    }
}