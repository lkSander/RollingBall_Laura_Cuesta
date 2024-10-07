using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocity;
    [SerializeField] Vector3 movimiento;
    float timer = 0f;
    bool cambiarDireccion=false;
   
   
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
        transform.Translate(movimiento.normalized * velocity * Time.deltaTime);



        if (timer >= 2)
        {
            movimiento = movimiento * -1;
            transform.eulerAngles = new Vector3(0, -90, 0);
            
            timer = 0;


        }



        if (timer >= 2)
        {
            movimiento = movimiento * -1;

            //transform.eulerAngles = new Vector3(0, 90, 0);

            timer = 0;
        }




        //Debug.Log(timer);




        //if (cambiarDireccion == true)
        //{
        //    transform.Translate(movimiento.normalized * velocity * Time.deltaTime);
        //    transform.eulerAngles = new Vector3(0f, 90f, 0f);
        //}
        //else if (cambiarDireccion == false)
        //{
        //    transform.Translate(movimiento.normalized * velocity * Time.deltaTime);
        //    transform.eulerAngles = new Vector3(0f, 270f, 0f);
        //}

        //if (timer >= 3 && cambiarDireccion == true)
        //{
        //    cambiarDireccion = false;
        //    timer = 0f;
        //}
        //else if (timer >= 3 && cambiarDireccion == false)
        //{
        //    cambiarDireccion = true;
        //    timer = 0f;
        //}










    }
}
