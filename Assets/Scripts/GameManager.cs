using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
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
            SceneManager.LoadSceneAsync("Game");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("Menu");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Key":
                Debug.Log("Touched key");
                Destroy(key);
                Destroy(door);
                break;
            case "FinishObject":
                finishGame();
                break;
        }
    }

    void finishGame()
    {
        isFinished = true;
        finishUI.SetActive(true);
    }
}