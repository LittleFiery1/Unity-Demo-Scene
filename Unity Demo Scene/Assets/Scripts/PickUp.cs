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
        Selected = selected;
    }
    
    private void FixedUpdate()
    {
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
