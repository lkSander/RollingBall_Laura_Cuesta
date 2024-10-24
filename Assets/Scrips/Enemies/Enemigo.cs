using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocity;
    [SerializeField] Vector3 movimiento;
    float timer = 0f;
    bool cambiarDireccion=true;
   
   
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
        //transform.Translate(movimiento.normalized * velocity * Time.deltaTime);

        transform.Translate(movimiento.normalized * velocity * Time.deltaTime);

        //if(cambiarDireccion==true)
        //{
        //    transform.eulerAngles = new Vector3(0, -90, 0);

        //}
        //else if(cambiarDireccion==false)
        //{
        //    transform.eulerAngles = new Vector3(0, 90, 0);
        //}

        transform.eulerAngles = new Vector3(0, cambiarDireccion ? -90 : 90, 0);




        if (timer >= 2)
        {
            cambiarDireccion = !cambiarDireccion;
            //movimiento = movimiento * -1;
            //transform.eulerAngles = new Vector3(0, -90, 0);
            
            timer = 0;

            
        }










    }
}
