using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public Transform searchPoint;
    private const float searchRadius = 0.5f;
    public LayerMask searchLayer;
    public GameObject foundObject;
 
    void Update()
    {
        if(FindObject())
        {
            if (IsKeyPressed())
            {
                //interact
                foundObject.GetComponent<Item>().Interact();
            }
        }
    }

    bool IsKeyPressed()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool FindObject()
    {
        Collider2D obj = Physics2D.OverlapCircle(searchPoint.position, searchRadius, searchLayer);
        
        if (obj == null)
        {
            return false;
        }
        else
        {
            foundObject = obj.gameObject;
            return true;
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(searchPoint.position, searchRadius);
    }
}
