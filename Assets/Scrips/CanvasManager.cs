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



    private void Start()
    {
        play.gameObject.SetActive(false);
        close.gameObject.SetActive(false);
    }
    private void Update()
    {
        Settings();
    }
    void Settings()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && canvaSettings.activeSelf)
        {

            Time.timeScale = 1;
            play.gameObject.SetActive(false);
            close.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !canvaSettings.activeSelf)
        {

            Time.timeScale = 0;
            play.gameObject.SetActive(true);
            close.gameObject.SetActive(true);
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
