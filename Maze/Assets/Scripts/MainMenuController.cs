using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    public void PlayGame ()
    {
        int scene = Random.Range(0, 10);
        if (scene < 5)
        {
            scene = 1;
        }
        else
        {
            scene = 2;
        }
        SceneManager.LoadScene(scene);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

}
