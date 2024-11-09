using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Camera2Trigger : MonoBehaviour
{
    float timer;
    [SerializeField] GameObject camera1;
    [SerializeField] GameObject camera2;
    [SerializeField] float timerMax;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = timerMax;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(camera2==true)
        {
            timer-=Time.deltaTime;
        }
        if (timer <= 0)
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            timer = timerMax;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
         if(other.CompareTag("Player"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }
}
