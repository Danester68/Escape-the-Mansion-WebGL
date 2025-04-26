using System;
using System.Data.Common;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public GameObject lightObject1;
    public GameObject lightObject2;
    public GameObject lightObject3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void ToggleLight(String tag) {
        switch (tag) {
            case "LightSwitch1":
                if (lightObject1.activeInHierarchy == true) {
                    lightObject1.SetActive(false);
                } else if (lightObject1.activeInHierarchy == false) {
                    lightObject1.SetActive(true);
                }
                break;
            case "LightSwitch2":
                if (lightObject2.activeInHierarchy == true) {
                    lightObject2.SetActive(false);
                } else if (lightObject2.activeInHierarchy == false) {
                    lightObject2.SetActive(true);
                }
                break;
            case "LightSwitch3":
                if (lightObject3.activeInHierarchy == true) {
                    lightObject3.SetActive(false);
                } else if (lightObject3.activeInHierarchy == false) {
                    lightObject3.SetActive(true);
                }
                break;
            default:
                Debug.LogError("Tag not correct");
                break;
        }
        
    }
}
