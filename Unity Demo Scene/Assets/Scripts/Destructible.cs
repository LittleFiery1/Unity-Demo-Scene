using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    [SerializeField]
    private GameObject box;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
            //Debug.Log("Layer 2");
        }
        //Debug.Log("Layer 1");
    }
}
