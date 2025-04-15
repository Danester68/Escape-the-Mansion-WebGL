using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    public GameObject light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (light.activeInHierarchy == false)
            {
                light.SetActive(true);
            } else if (light.activeInHierarchy == true)
            {
                light.SetActive(false);
            }
        }
    }
}
