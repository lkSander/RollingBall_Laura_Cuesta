using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    // Start is called before the first frame update
    private bool inicioTimer = false;
    private float timer = 2f;
   [SerializeField] private Rigidbody[] rbs;
    void Start()
    {
        inicioTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        //EL TIMER SIEMPRE EN EL UPDATE
        if (inicioTimer == true)
        {
            Time.timeScale = 0.4f;
            timer -= Time.unscaledDeltaTime;//no afecta el lento al resto y así no tenemos que configurar la variable.

            if (timer <= 0)
            {
                Time.timeScale = 1;
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].useGravity = true;
                }
            }


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inicioTimer=true;
        }
    }
}
