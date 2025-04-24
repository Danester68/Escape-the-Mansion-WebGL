using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkGameManager : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    public GameObject finishObject;
    public GameObject finishUI;

    private bool isFinished;
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
            Cursor.lockState = CursorLockMode.None;
            NetworkManager.Singleton.Shutdown();
            SceneManager.LoadSceneAsync("Multiplayer");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            NetworkManager.Singleton.Shutdown();
            SceneManager.LoadSceneAsync("Menu");
        }
        if (key.activeInHierarchy == false) {
            Debug.Log("Touched key");
            Destroy(door);
        }
    }

    public void finishGame()
    {
        Debug.Log("Finished game");
        isFinished = true;
        finishUI.SetActive(true);
    }
}