/**
 
 LevelComplete.cs

 This file deals with transitioning the player from one level to the next after the player complete a level
 --
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
