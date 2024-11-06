using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject canvaSettings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Settings()
    {
        canvaSettings.SetActive(!canvaSettings.activeSelf);
         Time.timeScale = 0;
    }
    private void Play()
    {
        canvaSettings.SetActive(false);
        Time.timeScale = 1;
        
    }
    private void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
