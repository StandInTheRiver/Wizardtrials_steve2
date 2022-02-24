using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_attack_anim : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "enemy")
        {

            //play anim
            anim.SetTrigger("hit_occured");

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
