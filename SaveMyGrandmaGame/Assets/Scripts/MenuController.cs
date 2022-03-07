using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public AudioSource ad;
    public void PlayGame()
    {
        /*SceneManager.LoadScene("BeginAnimation");*/
        ad.Stop();
        SceneManager.LoadScene("Level01");
    }
    public void GoToInstruction()
    {
        SceneManager.LoadScene("Instruction");
    }
    public void Exit()
    {
        Application.Quit();
    }
}

