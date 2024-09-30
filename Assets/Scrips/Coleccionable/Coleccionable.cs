using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 rotar;
    [SerializeField] float velocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotar * velocity * Time.deltaTime);
    }
}
