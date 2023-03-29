using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Overrides -> Apply All pour l'apliquer à tout les objets du même nom
    private float topBound = 30; // Destruction de l'objet à une certaine distance vers l'avant
    private float lowerBound = -10; // Destruction de l'objet à une certaine distance vers l'arrière

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
