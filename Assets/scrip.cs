using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scrip : MonoBehaviour {

	public void PlayGame()
    {
        //plays the next scene in the queue
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("PlayScene", LoadSceneMode.Additive);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("PlayScene"));

    }

    public void QuitGame()
    {
        Debug.Log("exited game");
        Application.Quit();

    }
}
