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

        canvaSettings.SetActive(false);
        Time.timeScale = 1;
    }
    private void Update()
    {
        
    }
    public void Settings()
    {
        
        if (canvaSettings.activeSelf)
        {
            Time.timeScale = 1;
            canvaSettings.SetActive(false);
        }

        if (!canvaSettings.activeSelf)
        {
            canvaSettings.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void Play()
    {
        canvaSettings.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit()
    {
     SceneManager.LoadScene(0);
    }
}
