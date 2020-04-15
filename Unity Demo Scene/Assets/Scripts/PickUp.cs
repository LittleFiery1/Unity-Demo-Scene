using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : InteractiveObject
{
    [SerializeField]
    [Tooltip("Must be the first person camera.")]
    private GameObject playerCharacter;
    private bool Selected;
    public override void HoldInteractive(bool selected)
    {
        base.HoldInteractive(selected);
        //Sets when an object is being picked up.
        Selected = selected;
    }
    
    private void FixedUpdate()
    {
        //Turns isKinematic on and off based on whether or not the object is picked up.
        if (Selected)
        {
            transform.position = playerCharacter.transform.position + playerCharacter.transform.forward * 3;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
