using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object that entered the triggered : ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
