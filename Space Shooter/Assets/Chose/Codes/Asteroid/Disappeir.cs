using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappeir : MonoBehaviour
{
    public GameObject partical;

    GameControl gameControl;
    GameObject control;
    
    void Start()
    {
        control = GameObject.FindGameObjectWithTag("Game Control");
        gameControl = control.GetComponent<GameControl>();
    }


    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Limit")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ///Instantiate(GO, col.transform.position, col.transform.rotation);         // Partical için    oluþacak obje  , oluþacak obje Pozisyonu  ,  oluþacak obje Rotasyonu.
            gameControl.ScoreUp(10);
        }
        if (other.tag == "Player")
        {
            gameControl.GameOver();
        }
    }
}