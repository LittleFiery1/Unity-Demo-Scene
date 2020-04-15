using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLeverSelection : InteractiveObject
{
    [SerializeField]
    [Tooltip("For setting which object is pointing left (true) and which one is pointing right (false).")]
    private bool leftNotRight;
    private Animator leverAnimator;
    private GameObject[] selections;

    protected override void Awake()
    {
        base.Awake();
        //Finds the animator of the Turn Lever
        leverAnimator = GameObject.Find("Turn Lever Shaft").gameObject.GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        base.InteractWith();
        //Turns the lever left or right based on what the arrow is set as.
        if (leftNotRight)
        {
            leverAnimator.Play("Lever_Turn_Left");
        }
        else
        {
            leverAnimator.Play("Lever_Turn_Right");
        }

        //Turns off both arrows when one is selected.
        selections = GameObject.FindGameObjectsWithTag("Turn Lever Selection");
        foreach (GameObject selection in selections)
        {
            selection.SetActive(false);
        }
    }
}