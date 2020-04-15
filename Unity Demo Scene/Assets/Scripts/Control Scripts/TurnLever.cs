using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLever : InteractiveObject
{
    private Animator animator;

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        base.InteractWith();
        transform.Find("Turn Lever Left").gameObject.SetActive(true);
        transform.Find("Turn Lever Right").gameObject.SetActive(true);
    }
}
