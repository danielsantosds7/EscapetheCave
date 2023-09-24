using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public bool temChave;
    public Animator portAnime;
    void Start()
    {
        instance= this;
        temChave = false;
        
    }

    public void PegaChave()
    {
        temChave = true;
        portAnime.SetBool("Key", temChave);
    }
}
