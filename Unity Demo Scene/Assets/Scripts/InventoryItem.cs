using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    [Tooltip("Used to show an object's icon.")]
    [SerializeField]
    private Image iconImage;

    public static event Action<InventoryObject> InventoryItemSelected;

    [SerializeField]
    private InventoryObject inventoryObjectInSlot;

    public InventoryObject InventoryObjectInSlot
    {
        get
        {
            return inventoryObjectInSlot;
        }
        set
        {
            inventoryObjectInSlot = value;
            iconImage.sprite = inventoryObjectInSlot.Icon;
        }
    }

    public void ItemWasToggled(bool isOn)
    {
        if (isOn)
        {
            InventoryItemSelected?.Invoke(InventoryObjectInSlot);
        }
    }

    private void Awake()
    {
        Toggle toggle = GetComponent<Toggle>();
        ToggleGroup togglegroup = GetComponentInParent<ToggleGroup>();
        toggle.group = togglegroup;
    }
}