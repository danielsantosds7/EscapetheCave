using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDControl : MonoBehaviour
{
    public static HUDControl hControl { get; private set; }
    public GameObject joiaOnOff;
    public bool joiaOn;
    public GameObject joia2OnOff;
    public bool joia2On;
    public GameObject joia3OnOff;
    public bool joia3On;

    private void Awake()
    {
        if (hControl == null)
        {
            hControl = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void JoiaOn()
    {
        joiaOnOff.SetActive(true);
        joiaOn = true;
    }
    public void Joia2On()
    {
        joia2OnOff.SetActive(true);
        joia2On = true;
    }
    public void Joia3On()
    {
        joia3OnOff.SetActive(true);
        joia3On = true;
    }
}