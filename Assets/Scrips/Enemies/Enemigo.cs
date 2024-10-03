using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocity;
    [SerializeField] Vector3 movimiento;
    float timer = 0f;
   
   
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
                transform.eulerAngles = new Vector3(0, 180, 0);
                
                timer = 0;
                
              
            }
        

            
            if (timer >= 2)
            {
               movimiento = movimiento * -1;
           
                transform.eulerAngles = new Vector3(0, 0, 0);
               
                timer = 0;
            }

        

       
        Debug.Log(timer);


    }
}
