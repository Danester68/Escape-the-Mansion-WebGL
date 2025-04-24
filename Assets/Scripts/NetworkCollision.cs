using UnityEngine;

public class NetworkCollision : MonoBehaviour
{

    public NetworkGameManager networkGameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        networkGameManager = GameObject.FindGameObjectWithTag("NetworkGameManager").GetComponent<NetworkGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key") {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "FinishObject") {
            networkGameManager.finishGame();
        }
    }
}
