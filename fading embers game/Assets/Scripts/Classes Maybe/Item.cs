using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Item : MonoBehaviour
{
    public enum ItemType {NONE, Look, PickUp};
    public ItemType type;
    public SpriteRenderer item_sr;
    public string ItemName;


    //possible fields
    // craftable?
    // description?

    private void Start()
    {
            item_sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Reset()
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 10;
    }

    public void Interact()
    {
        switch(type)
        {
            case ItemType.Look:
                //text stuff
                break;
            case ItemType.PickUp:
                //add to inventory
                FindFirstObjectByType<InventoryManager>().PickUp(gameObject);
                gameObject.SetActive(false);
                //delete item from world
                break;
            default:
                break;
        }
    }
}
