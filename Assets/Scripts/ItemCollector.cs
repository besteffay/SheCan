using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int itemsCollected = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CollectableItem"))
        {
            Destroy(collision.gameObject);
            itemsCollected++;
            Debug.Log(itemsCollected);
        }
    }
}
