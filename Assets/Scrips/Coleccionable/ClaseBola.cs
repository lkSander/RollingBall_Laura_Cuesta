using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseBola : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float velocity;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * velocity, ForceMode.Impulse);
                }
    }
}
