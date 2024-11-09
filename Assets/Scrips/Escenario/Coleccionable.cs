using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 rotar;
    [SerializeField] float velocity;
   // [SerializeField] AudioClip sonidoRecoger;
    //[SerializeField] AudioManager audioSourceSfx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotar * velocity * Time.deltaTime);
    }

   //// private void OnTriggerEnter(Collider other)
   // {
   //     if (other.CompareTag("Player"))
   //     {
   //         audioSourceSfx.ReproducirSonido(sonidoRecoger);
   //     }

   // }

}

