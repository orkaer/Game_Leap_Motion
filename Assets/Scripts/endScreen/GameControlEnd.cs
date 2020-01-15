using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlEnd : MonoBehaviour
{
    public void OpenLevel1()
    {
        SceneManager.LoadScene("enteenteente");
    }

    public void Quit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}