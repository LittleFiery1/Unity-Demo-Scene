using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLeverSelection : InteractiveObject
{
    [SerializeField]
    private bool leftNotRight;
    private Animator leverAnimator;
    private GameObject[] selections;

    protected override void Awake()
    {
        base.Awake();
        leverAnimator = GameObject.Find("Turn Lever Shaft").gameObject.GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        base.InteractWith();
        if (leftNotRight)
        {
            leverAnimator.Play("Lever_Turn_Left");
        }
        else
        {
            leverAnimator.Play("Lever_Turn_Right");
        }

        selections = GameObject.FindGameObjectsWithTag("Turn Lever Selection");

        foreach (GameObject selection in selections)
        {
            selection.SetActive(false);
        }
    }
}