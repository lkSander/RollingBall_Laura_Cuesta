using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocity;
    [SerializeField] Vector3 movimiento;
   
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
        //transform.position += new Vector3(0, 0, 1).normalized * velocity * Time.deltaTime;
        transform.Translate (movimiento.normalized * velocity * Time.deltaTime);
       
    }
}
