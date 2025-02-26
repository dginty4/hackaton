using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove : MonoBehaviour
{
    public static int previousScene;
    private void OnTriggerEnter2D(Collider2D other)
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        switch (other.gameObject.tag)
        {
            case "levelMove":
                UpdatePreviousScene();
                SceneManager.LoadScene(nextSceneIndex);
                break;
            
            case "terminal":
                UpdatePreviousScene();
                SceneManager.LoadScene(nextSceneIndex);
                break;
        }
    }
    
    private void UpdatePreviousScene()
    {
        previousScene = SceneManager.GetActiveScene().buildIndex;
    }
}
