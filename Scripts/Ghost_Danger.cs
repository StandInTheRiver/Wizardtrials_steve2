using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Danger : MonoBehaviour
{
    public float danger_duration;
    public CircleCollider2D self;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<CircleCollider2D>();
        anim = GetComponent<Animator>();

        InvokeRepeating("Danger", 1f, danger_duration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Danger()
    {
        //turn off collision
        //turn off danger display
        if (self.enabled)
        {
            anim.SetBool("danger", false);
            self.enabled = !self.enabled;
        }

        //turn on collision
        //turn on danger display
        else
        {

            anim.SetBool("danger", true);
            self.enabled = true;
        }
    }
}
