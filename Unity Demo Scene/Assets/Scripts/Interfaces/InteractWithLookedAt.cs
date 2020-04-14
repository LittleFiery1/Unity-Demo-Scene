﻿using System.Collections;
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
            //Debug.Log("Player pressed interact button");
            lookedAtInteractive.InteractWith();
        }

        if (Input.GetButton("Interact") && lookedAtInteractive != null && heldInteractive == null)
        {
            heldInteractive = lookedAtInteractive;
            heldInteractive.HoldInteractive(true);
        }

        if (Input.GetButtonUp("Interact") && heldInteractive != null)
        {
            heldInteractive.HoldInteractive(false);
            heldInteractive = null;
        }
    }

    private void OnLookedAtInteractiveChanged(IInteractive newLookedAtInteractive)
    {
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
