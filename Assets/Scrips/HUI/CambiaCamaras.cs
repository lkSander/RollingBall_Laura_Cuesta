using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CambiaCamaras : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject camaraCenital;
    [SerializeField] GameObject camaraNormal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (camaraNormal.activeSelf)
            {
                camaraNormal.SetActive(false);
                camaraCenital.SetActive(true);

            }
            else
            {
                camaraNormal.SetActive(false);
                camaraCenital.SetActive(true);

            }
        }
 
    }


   
}
