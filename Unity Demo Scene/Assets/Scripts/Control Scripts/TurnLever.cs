using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLever : InteractiveObject
{
    private Animator animator;

    public override void InteractWith()
    {
        base.InteractWith();
        //Turns on both arrows when clicked.
        transform.Find("Turn Lever Left").gameObject.SetActive(true);
        transform.Find("Turn Lever Right").gameObject.SetActive(true);
    }
}
