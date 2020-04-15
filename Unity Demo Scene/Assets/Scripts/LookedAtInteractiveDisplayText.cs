using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookedAtInteractiveDisplayText : MonoBehaviour
{
    /// <summary>
    /// UI Text displaying info about interactive objects.
    /// </summary>
    private IInteractive lookedAtInteractive;
    private Text displayText;

    private void Awake()
    {
        displayText = GetComponent<Text>();
        UpdateDisplayText();
    }

    private void UpdateDisplayText()
    {
        if (lookedAtInteractive != null)
        {
            displayText.text = lookedAtInteractive.DisplayText;
        }
        else
        {
            displayText.text = string.Empty;
        }
    }
    /// <summary>
    /// Event handler for DetectLookAtInteractive.LookedAtInteractiveChange
    /// </summary>
    /// <param name="newLookedAtInteractive"></param>
    private void OnLookedAtInteractiveChange(IInteractive newLookedAtInteractive)
    {
        lookedAtInteractive = newLookedAtInteractive;
        UpdateDisplayText();
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
