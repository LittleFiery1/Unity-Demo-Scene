using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vibrate : MonoBehaviour
{
    [Tooltip("Alters the distance the object's position will shift.")]
    [SerializeField]
    private float vibrateDistance = 1.0f;
    private float xPos;
    private float yPos;
    private float zPos;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Adjust the position of the game object each frame.
        vibrateDistance = -vibrateDistance;
        xPos = gameObject.GetComponent<Transform>().localPosition.x;
        yPos = gameObject.GetComponent<Transform>().localPosition.y + vibrateDistance;
        zPos = gameObject.GetComponent<Transform>().localPosition.z;
        gameObject.GetComponent<Transform>().localPosition = new Vector3(xPos,yPos,zPos);
    }
}
