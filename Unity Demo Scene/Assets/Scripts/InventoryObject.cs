using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : InteractiveObject
{
    [Tooltip("Name of the object, as it will appear in the inventory.")]
    [SerializeField]
    private string objectName = nameof(InventoryObject);

    public string ObjectName => objectName;

    [Tooltip("Text that displays when the player selects this object in the inventory.")]
    [TextArea(3,8)]
    [SerializeField]
    private string description;

    [Tooltip("Image for this object in the inventory.")]
    [SerializeField]
    private Sprite icon;

    public Sprite Icon => icon;
    public string Description => description;

    private new Renderer renderer;
    private new Collider collider;
    public InventoryObject()
    {
        displayText = $"Take {objectName}";
    }

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }

    public override void InteractWith()
    {
        base.InteractWith();
        PlayerInventory.InventoryObjects.Add(this);
        InventoryMenu.Instance.AddItemToInventory(this);
        renderer.enabled = false;
        collider.enabled = false;
    }
}
