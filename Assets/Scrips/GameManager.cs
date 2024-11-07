using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject canvaSettings;
    [SerializeField] Button play;
    [SerializeField] Button quit;
    // Start is called before the first frame update
    void Start()
    {
        play.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Settings()
    {
        canvaSettings.SetActive(!canvaSettings.activeSelf);
        Time.timeScale = 0;
        play.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
    }
    void Play()
    {
        canvaSettings.SetActive(false);
        Time.timeScale = 1;
        play.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }
    void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
