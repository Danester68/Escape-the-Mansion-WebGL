using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject multiplayerPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) {
            if (multiplayerPanel.activeInHierarchy == true) {
                multiplayerPanel.SetActive(false);
                //Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
            } else if (multiplayerPanel.activeInHierarchy == false) {
                multiplayerPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                //Time.timeScale = 0;
            }
        }
    }
}
