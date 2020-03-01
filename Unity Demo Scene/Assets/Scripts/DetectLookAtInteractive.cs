using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects interactive elements the player is looking at.
/// </summary>
public class DetectLookAtInteractive : MonoBehaviour
{
    [Tooltip("Origin of raycast for detecting interactibles.")]
    [SerializeField]
    private Transform raycastOrigin;

    [Tooltip("Distance from the raycast origin.")]
    [SerializeField]
    private float maxRange = 5.0f;

    public IInteractive LookedAtInteractive
    {
        get { return lookedAtInteractive; }
        private set { lookedAtInteractive = value; }
    }

    private IInteractive lookedAtInteractive;

    private void FixedUpdate()
    {
        Debug.DrawRay(raycastOrigin.position, raycastOrigin.forward * maxRange, Color.red);
        RaycastHit hitInfo;
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        bool objectWasDetected = Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out hitInfo, maxRange, layerMask);

        IInteractive interactive = null;

        LookedAtInteractive = interactive;

        if (objectWasDetected)
        {
            //Debug.Log($"Name = {hitInfo.collider.gameObject.name}");
            interactive = hitInfo.collider.gameObject.GetComponent<IInteractive>();
        }

        if (interactive != null)
        {
            lookedAtInteractive = interactive;
        }
    }
}
