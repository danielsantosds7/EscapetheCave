using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joia : MonoBehaviour
{
    HUDControl hControl;
    void Start()
    {
        hControl = HUDControl.hControl;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Joia1")
        {

            hControl.JoiaOn();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Joia2")
        {
            hControl.Joia2On();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Joia3")
        {
            hControl.Joia3On();
            Destroy(gameObject);
        }
    }
}