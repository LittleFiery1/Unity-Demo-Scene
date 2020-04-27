using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [Tooltip("Text that displays when the player is looking at an interactive object.")]
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);
    public virtual string DisplayText => displayText;
    protected AudioSource audioSource;
    protected virtual void Awake()
    {
        //Grabs the audio source
        audioSource = GetComponent<AudioSource>();
    }
    public virtual void InteractWith()
    {
        //Leaves a debug message if an audio source cannot be played.
        try
        {
            audioSource.Play();
        }
        catch (System.Exception)
        {
            throw new System.Exception("New interactive component needs an audio source.");
        }
    }

    public virtual void HoldInteractive(bool selected)
    {

    }
}