using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    [SerializeField] public float velocity;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        
    }

    void Movimiento()

    {

        float h= Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");




        //float z = 0;
        //float x = 0;

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //z++;
        //    transform.position += new Vector3(0, 0, 1).normalized * velocity*Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A)&& Input.GetKey(KeyCode.W))
        //{
            
        //    transform.position += new Vector3(-1, 0, 1).normalized * velocity*Time.deltaTime;
           
        //}
        ////    x--;
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, -1).normalized * velocity * Time.deltaTime;
        //    //    z--;
        //}
        //if (Input.GetKey(KeyCode.D)&& Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(1, 0, 1).normalized * velocity* Time.deltaTime;
        //    //    x++;
        //}
        ////rb.velocity = new Vector3(x * velocity, 0, z * velocity);

        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.eulerAngles= new Vector3 (0,90,0);
        //}

       
        
    }
    

}

