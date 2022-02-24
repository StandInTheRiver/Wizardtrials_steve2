using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_dmg : MonoBehaviour
{
    private BoxCollider2D my_hitbox;
    public bool take_hit;
    public int hits_taken = 0;


    // Start is called before the first frame update
    void Start()
    {
        //my_hitbox = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player_Hitbox_regular")
        {
            Debug.Log("hit detected");
            hits_taken +=1;
        }
    }
}
