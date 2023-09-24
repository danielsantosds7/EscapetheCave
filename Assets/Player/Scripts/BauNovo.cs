using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BauNovo : MonoBehaviour
{
    
    public GameObject item;
    public float delay;
    public Animator anime;

    private void Start()
    {
        item.SetActive(false);
    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
          anime.SetBool("Open", true);
           Invoke("ShowItem", delay);
        }
    }
    void ShowItem()
    {
        if (item != null)
        {
            item.SetActive(true);
        }
    }
}
