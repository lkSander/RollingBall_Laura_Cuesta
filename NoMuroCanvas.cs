using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMuroCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject noMuro;
    [SerializeField] Player player;
    void Start()
    {
       noMuro.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Player>().AtravesarPared(true))
        {
            noMuro.SetActive(true); 
        }
    }
}
