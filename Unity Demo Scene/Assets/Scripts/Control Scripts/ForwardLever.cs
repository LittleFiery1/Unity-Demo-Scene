using UnityEngine;

public class ForwardLever : InteractiveObject
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
        animator.SetTrigger("Pushed");
    }
}
