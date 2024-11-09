using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector2 checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
