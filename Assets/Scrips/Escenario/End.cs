using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
    }
}