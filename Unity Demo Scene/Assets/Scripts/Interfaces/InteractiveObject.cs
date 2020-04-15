using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [Tooltip("Text that displays when the player is looking at an interactive object.")]
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);
    public string DisplayText => displayText;
    private AudioSource audioSource;
    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public virtual void InteractWith()
    {
        try
        {
            audioSource.Play();
        }
        catch (System.Exception)
        {
            throw new System.Exception("New interactive component needs an audio source.");
        }
        Debug.Log($"Player Interacted With {gameObject.name}");
    }

    public virtual void HoldInteractive(bool selected)
    {

    }
}