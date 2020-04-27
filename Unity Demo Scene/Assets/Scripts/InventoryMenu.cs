using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject togglePrefab;

    [Tooltip("The content object of the inventory scroll view.")]
    [SerializeField]
    private Transform inventoryContent;

    [Tooltip("Text for the name of the object displayed in the inventory menu.")]
    [SerializeField]
    private Text itemLabelText;

    [Tooltip("Text for the description of the object displayed in the inventory menu.")]
    [SerializeField]
    private Text itemDescriptionText;

    [SerializeField]
    private InteractWithLookedAt interactWithLookedAt;

    private CanvasGroup canvasGroup;
    private static InventoryMenu instance;
    private FirstPersonController firstPersonController;
    private bool IsVisible => canvasGroup.alpha > 0;

    public static InventoryMenu Instance
    {
        get
        {
            if (instance == null)
            {
                throw new System.Exception("Please plase an instance with an Inventory Menu Script in the scene.");
            }
            return instance;
        }
        private set
        {
            instance = value;
        }
    }

    public void ClickExitMenuButton()
    {
        HideInventory();
    }

    public void AddItemToInventory(InventoryObject objectBeingAdded)
    {
        GameObject clone = Instantiate(togglePrefab, inventoryContent);
        InventoryItem item = clone.GetComponent<InventoryItem>();
        item.InventoryObjectInSlot = objectBeingAdded;
    }

    public void RemoveItemFromInventory(InventoryObject objectBeingRemoved)
    {
        var inventoryItemsList = FindObjectsOfType<InventoryItem>();
        foreach (InventoryItem inventoryItem in inventoryItemsList)
        {
            if (inventoryItem.InventoryObjectInSlot == objectBeingRemoved)
            {
                Destroy(inventoryItem.gameObject);
            }
        }
    }

    private void ShowInventory()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        firstPersonController.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        interactWithLookedAt.enabled = false;
    }

    private void HideInventory()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        firstPersonController.enabled = true;
        interactWithLookedAt.enabled = true;
    }

    private void OnInventoryItemSelected(InventoryObject itemThatWasSelected)
    {
        itemLabelText.text = itemThatWasSelected.ObjectName;
        itemDescriptionText.text = itemThatWasSelected.Description;
    }

    private void OnEnable()
    {
        InventoryItem.InventoryItemSelected += OnInventoryItemSelected;
    }

    private void OnDisable()
    {
        InventoryItem.InventoryItemSelected -= OnInventoryItemSelected;
    }

    private void Update()
    {
        ToggleInventory();
    }

    private void ToggleInventory()
    {
        if (Input.GetButtonDown("Inventory Menu"))
        {
            if (IsVisible)
            {
                HideInventory();
            }
            else
            {
                ShowInventory();
            }
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            throw new System.Exception("There cannot be more than on Inventory Menu instance, and this script can't be on anthing aside from the inventory menu");
        }

        canvasGroup = GetComponent<CanvasGroup>();
        firstPersonController = FindObjectOfType<FirstPersonController>();
        interactWithLookedAt = FindObjectOfType<InteractWithLookedAt>();
    }

    private void Start()
    {
        HideInventory();
    }
}
