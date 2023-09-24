using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuIncial;
    [SerializeField] private GameObject painelOpcoes;


    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }
    public void AbrirOpcoes()
    {
        painelOpcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
    }
    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
