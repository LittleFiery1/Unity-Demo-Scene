﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : InteractiveObject
{
    [SerializeField]
    [Tooltip("Must be the first person camera.")]
    private GameObject playerCharacter;
    [SerializeField]
    private float distance = 3.0f;
    private bool Selected;
    private Rigidbody rigidbody;
    public override void HoldInteractive(bool selected)
    {
        base.HoldInteractive(selected);
        //Sets when an object is being picked up.
        Selected = selected;
        rigidbody = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        //Turns isKinematic on and off based on whether or not the object is picked up.
        if (rigidbody != null)
        {
            if (Selected)
            {
                rigidbody.isKinematic = true;
                transform.position = playerCharacter.transform.position + playerCharacter.transform.forward * distance;
            }
            else
            {
                rigidbody.isKinematic = false;
            }
        }
    }
}
