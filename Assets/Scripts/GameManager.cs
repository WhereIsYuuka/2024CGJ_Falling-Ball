using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;
    public Transform spawnPoint;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Respawn() {
        Debug.Log("Respawn");
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.transform.position = spawnPoint.position;
    }

    public void QuitGame() {
        Application.Quit();
    }
}
