using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a : MonoBehaviour
{ 
   [SerializeField] GameObject canvaSettings;
  // Start is called before the first frame update

   void Settings()
{
    canvaSettings.SetActive(!canvaSettings.activeSelf);
    Time.timeScale = 0;
}
  void Play()
  {
    canvaSettings.SetActive(false);
    Time.timeScale = 1;

   }
   void Quit()
   {
    SceneManager.LoadScene(0);
   }
}
