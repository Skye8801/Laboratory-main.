using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayPong : MonoBehaviour
{
    public void ChangeScene(string sceneName) 
    {

         if(Input.GetKeyDown(KeyCode.E))
         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            // SceneManager.LoadScene(sceneName);
         }


    }

}