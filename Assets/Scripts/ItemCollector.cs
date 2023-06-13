using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public int itemsCollected = 0;
    private bool powerItemCollected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CollectableItem") || collision.gameObject.CompareTag("PowerItem"))
        {
            
            if(collision.gameObject.CompareTag("PowerItem"))
            {
                powerItemCollected = true; 
            }

            Destroy(collision.gameObject);
            itemsCollected++;
            Debug.Log(itemsCollected);
        }
    }

}
