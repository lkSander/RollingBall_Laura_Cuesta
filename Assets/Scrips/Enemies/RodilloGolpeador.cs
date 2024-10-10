using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodilloGolpeador : MonoBehaviour
{
    [SerializeField] Vector3 rotar;
    [SerializeField] private float velocity;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(rotar * velocity, ForceMode.VelocityChange);
    }


    // Update is called once per frame
    void Update()
    {
        //rb=direccionR(global)*fuerza,ForceMode.TipoF(Impulse/Force)

    }
}
