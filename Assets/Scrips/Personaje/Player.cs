using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float alturaSalto;
    [SerializeField] private float rayoSuelo;
    private float h;
    private float v;
    private int puntuacion;
    private Vector3 inicio;
    private int vida;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        v = Input.GetAxisRaw("Vertical");
        h = Input.GetAxisRaw("Horizontal");
        if (DetectarSuelo())
        {
            Salto();
        }
    }

    private void FixedUpdate()
    {
       
        rb.AddForce (new Vector3(v, 0, v).normalized * velocidadMovimiento, ForceMode.Acceleration);
       
    }
    void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce (new Vector3(0,1,0) * alturaSalto, ForceMode.VelocityChange);
        }
    }
    bool DetectarSuelo()
    {
        bool suelo = Physics.Raycast(gameObject.transform.position, Vector3.down, rayoSuelo);
        return suelo;
    }

}
