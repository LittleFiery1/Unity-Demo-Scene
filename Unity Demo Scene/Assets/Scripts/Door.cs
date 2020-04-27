using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    [Tooltip("The Inventory Object that is needed to unlock this door.")]
    [SerializeField]
    private InventoryObject key;

    [Tooltip("Determines if the key is destroyed when used on a door or not.")]
    [SerializeField]
    private bool consumeKey;

    [Tooltip("Text displayed when the door is locked.")]
    [SerializeField]
    private string lockedDisplayText = "Locked";

    [Tooltip("Audio played when interacting with door without the key.")]
    [SerializeField]
    private AudioClip lockedAudioClip;

    [Tooltip("Audio played when unlocking and opening a door.")]
    [SerializeField]
    private AudioClip openAudioClip;

    private InventoryMenu inventoryMenu;
    private bool isLocked = false;
    //public override string DisplayText => isLocked ? lockedDisplayText : base.DisplayText;
    private bool hasKey => PlayerInventory.InventoryObjects.Contains(key);
    private Animator animator;
    private bool isOpen = false;

    public override string DisplayText
    {
        get
        {
            string toReturn;
            if (isLocked)
            {
                toReturn = hasKey ? $"Use {key.ObjectName}" : lockedDisplayText;
            }
            else
            {
                toReturn = base.DisplayText;
            }
            return toReturn;
        }
    }

    public Door()
    {
        //Changes the displaytext of the door upon construction.
        displayText = nameof(Door);
    }

    protected override void Awake()
    {
        base.Awake();
        //Grabs the door
        animator = GetComponent<Animator>();
        ChecksIfLocked();
        inventoryMenu = FindObjectOfType<InventoryMenu>();
    }

    private void ChecksIfLocked()
    {
        if (key != null)
        {
            isLocked = true;
        }
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (isLocked && !hasKey)
            {
                audioSource.clip = lockedAudioClip;
            }
            else
            {
                audioSource.clip = openAudioClip;
                animator.SetTrigger("Selected");
                displayText = string.Empty;
                isOpen = true;
                UnlockDoor();
            }
            base.InteractWith();
        }
    }

    private void UnlockDoor()
    {
        isLocked = false;
        if (key != null && consumeKey)
        {
            PlayerInventory.InventoryObjects.Remove(key);
            inventoryMenu.RemoveItemFromInventory(key);
        }
    }
}