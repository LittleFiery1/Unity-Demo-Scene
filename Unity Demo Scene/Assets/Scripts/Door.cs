using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    private Animator animator;
    private bool isOpen = false;

    public Door()
    {
        //Changes the displaytext of the door upon construction.
        displayText = nameof(Door);
    }

    protected override void Awake()
    {
        base.Awake();
        //Grabs the door
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        //Does not allow door to be selected again after it has been opened.
        if (!isOpen)
        {
            base.InteractWith();
            animator.SetTrigger("Opened");
            displayText = string.Empty;
            isOpen = true;
        }
    }
}