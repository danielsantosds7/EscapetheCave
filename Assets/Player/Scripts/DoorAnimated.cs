using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimated : MonoBehaviour
{
    private Animator animatic;
    private void Awake()
    {
        
    animatic = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        animatic.SetBool("KeyY", true);
    }
    public void CloseDoor()
    {
        animatic.SetBool("KeyY", false);
    }
}
