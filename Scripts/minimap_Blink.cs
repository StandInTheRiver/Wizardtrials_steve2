using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap_Blink : MonoBehaviour
{
    public SpriteRenderer self;
    public bool set_flash;
    public bool set_flash2;
    public float inc_val;
    public Color darkcolor;
    public Color lightcolor;
    public int test_counter;
    public float darker = 1f;
    public float lighter = 0.5f;
    public float blinktimer;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<SpriteRenderer>();

        //get initial color
        darkcolor = self.color;
        lightcolor = self.color;

        //set variable colors
        darkcolor.a = darker;
        lightcolor.a = lighter;


        InvokeRepeating("Darken", 1f, blinktimer);
    }

    void Update()
    {

    }

    void Darken()
    {
        //if on, turn off
        if (self.color.a == darkcolor.a)
        {
            self.color = lightcolor;
        }

        //if off turn on
        else if (self.color.a != darkcolor.a)
        {
            self.color = darkcolor;
        }
    }

}
