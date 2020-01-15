using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public void OpenLevel1()  {
        SceneManager.LoadScene("enteenteente");
    }

    public void Quit() {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying=false;
    }

    /*public void openMenu(){
        if (Event.current.Equals(Event.KeyboardEvent("[enter]")))
        {
            SceneManager.LoadScene("Start_Duck");
        }
    }
    */
}