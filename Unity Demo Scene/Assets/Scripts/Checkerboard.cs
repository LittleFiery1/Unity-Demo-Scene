using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkerboard : InteractiveObject
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        base.InteractWith();
        animator.SetTrigger("Played");
    }
}
