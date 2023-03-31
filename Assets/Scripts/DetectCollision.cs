using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destruction de l'objet à la collision
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1); // -1 vie
            Destroy(gameObject);
        }
        else if(other.CompareTag("Animal"))
        {
            gameManager.AddScore(5);// Ajout du score
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
