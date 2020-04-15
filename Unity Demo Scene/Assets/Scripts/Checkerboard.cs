using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkerboard : InteractiveObject
{
    private Animator animator;

    protected override void Awake()
    {
        base.Awake();
        //Grabs the animator
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        base.InteractWith();
        //Plays the animation
        animator.SetTrigger("Played");
    }
}
