using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{ 
     [SerializeField] GameObject canvaSettings;
     [SerializeField] Button play;
     [SerializeField] Button close;
   void Settings()
    {

        if (!canvaSettings.activeSelf)
        {
            canvaSettings.SetActive(true);
            Time.timeScale = 0;
            play.gameObject.SetActive(true);
            close.gameObject.SetActive(true);
        }
        else
        {
            canvaSettings.SetActive(false);
            Time.timeScale = 1;
            play.gameObject.SetActive(false);
            close.gameObject.SetActive(false);
        }

    }

    void Play()
  {
    canvaSettings.SetActive(false);
    Time.timeScale = 1;
    play.gameObject.SetActive(false);
    close.gameObject.SetActive(false);

  }

   void Quit()
   {
    SceneManager.LoadScene(0);
   }
}
