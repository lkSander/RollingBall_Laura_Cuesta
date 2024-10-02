using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocity;
    [SerializeField] Vector3 movimiento;
    float timer = 0f;
    bool derecha=false;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {
        timer += Time.deltaTime;

        if (derecha == false)
        {
            transform.Translate(movimiento.normalized * velocity * Time.deltaTime);
            if (timer >= 2)
            {
               
                transform.Translate(movimiento.normalized * -1 * velocity * Time.deltaTime);
                transform.eulerAngles = new Vector3(0, 90, 0);
                derecha = true;
                timer = 0;
                
              
            }
        } 

        if (derecha == true)
        {
            transform.Translate(movimiento.normalized * 1 * velocity * Time.deltaTime);
            if (timer >= 2)
            {
                transform.Translate(movimiento.normalized * velocity * Time.deltaTime);
                transform.eulerAngles = new Vector3(0, 0, 0);
                derecha = false;
                timer = 0;
            }

        }

       
        Debug.Log(timer);


    }
}
