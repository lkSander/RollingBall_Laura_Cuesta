using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    [SerializeField] private float velocity;
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
        float z = 0;
        float x = 0;

        if (Input.GetKeyDown(KeyCode.W))
        {
            z++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            x--;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            z--;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            x++;
        }
        rb.velocity = new Vector3(x * velocity, 0, z * velocity);
    }
}
