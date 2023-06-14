using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public int itemsCollected = 0;
    private bool powerItemCollected = false;
    public GameObject finishCheckpoint;
    private BoxCollider2D finishCollider;

    private void Start()
    {
        finishCollider = finishCheckpoint.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CollectableItem") || collision.gameObject.CompareTag("PowerItem"))
        {
            
            if(collision.gameObject.CompareTag("PowerItem"))
            {
                powerItemCollected = true;
                Debug.Log("power item collected");
            }

            Destroy(collision.gameObject);
            itemsCollected++;
            Debug.Log(itemsCollected);
        }
    }

    private void Update()
    {
        if(itemsCollected>=4)
        {
            finishCollider.enabled = true;
        }
        else
        {
            finishCollider.enabled = false;
        }
    }
}
