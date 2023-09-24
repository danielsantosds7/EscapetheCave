using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public string cena;

    public void Pausado()
    {
        Time.timeScale = 0; // jogo esta pausado
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.Pause();
        }
    }
    public void SairDoPause()
    {
        Time.timeScale = 1; // sair do pause
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.Play();
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(cena);
    }

}
