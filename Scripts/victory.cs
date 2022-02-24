using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    public GameObject vc;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //playervictory screen
            vc.SetActive(true);
        }

    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
