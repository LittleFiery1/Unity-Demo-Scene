using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detects when the player presses the interact button when looking at an interactive object,
/// then calling the IInteractives InteractWith method.
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{
    private IInteractive lookedAtInteractive;
    private IInteractive heldInteractive;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && lookedAtInteractive != null)
        {
            //Interacts with the looked at interactive object when the button is pressed.
            lookedAtInteractive.InteractWith();
        }

        if (Input.GetButton("Interact") && lookedAtInteractive != null && heldInteractive == null)
        {
            //Sets an object as being the one that's "held".
            heldInteractive = lookedAtInteractive;
            heldInteractive.HoldInteractive(true);
        }

        if (Input.GetButtonUp("Interact") && heldInteractive != null)
        {
            //Removes object from being "held" causing it to drop.
            heldInteractive.HoldInteractive(false);
            heldInteractive = null;
        }
    }

    private void OnLookedAtInteractiveChanged(IInteractive newLookedAtInteractive)
    {
        //Updates what interactive object is being looked at.
        lookedAtInteractive = newLookedAtInteractive;
    }

    /// <summary>
    /// Event handler for DetectLookAtInteractive.LookedAtInteractiveChange
    /// </summary>
    /// <param name="newLookedAtInteractive"></param>
    private void OnLookedAtInteractiveChange(IInteractive newLookedAtInteractive)
    {
        lookedAtInteractive = newLookedAtInteractive;
    }

    #region Event subscription/unsubscription
    private void OnEnable()
    {
        DetectLookAtInteractive.LookedAtInteractiveChange += OnLookedAtInteractiveChange;
    }

    private void OnDisable()
    {
        DetectLookAtInteractive.LookedAtInteractiveChange -= OnLookedAtInteractiveChange;
    }
    #endregion
}
