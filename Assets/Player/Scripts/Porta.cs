using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Porta : MonoBehaviour
{
    public GameObject painelVitoria;
 
    private void Start()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (GameController.instance.temChave)
            {
                LoadVictory();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                Debug.Log("O player não tem chave");

            }
        }
        void LoadVictory()
        {
            painelVitoria.SetActive(true);
        }
    }
}