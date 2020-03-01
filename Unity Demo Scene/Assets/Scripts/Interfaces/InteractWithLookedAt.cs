using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detects when the player presses the interact button when looking at an interactive object,
/// then calling the IInteractives InteractWith method.
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{
    [SerializeField]
    private DetectLookAtInteractive detectLookAtInteractive;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && detectLookAtInteractive.LookedAtInteractive != null)
        {
            Debug.Log("Player pressed interact button");
            detectLookAtInteractive.LookedAtInteractive.InteractWith();
        }
    }
}
