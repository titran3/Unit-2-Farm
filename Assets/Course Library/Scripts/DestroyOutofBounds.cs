using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame        
    
    private float topBound = 30;
    private float lowerBound = -10;
    void Update()
    {
        // If object past players view it removes it
        if (transform.position.z > topBound)

        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
