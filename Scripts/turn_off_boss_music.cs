using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_off_boss_music : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //freeze location
        if (other.tag == "Player")
        {
            Invoke("kill", 1f);
        }

    }

    void kill()
    {
        Destroy(gameObject);
    }

}
