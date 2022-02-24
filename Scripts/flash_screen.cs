using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash_screen : MonoBehaviour

{
    public SpriteRenderer self;
    public bool set_flash;
    public bool set_flash2;
    public float inc_val;
    public Color stevecolor;
    public int test_counter;
    public bool cooldown;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<SpriteRenderer>();
        inc_val = 0.01f;
        stevecolor = self.color;
        
    }

    // Update is called once per frame
    void Update()
    {
        self.color = stevecolor;
    }

    public IEnumerator LerpUp()
    {

        if (cooldown == false)
        {
            cooldown = true;
            while (stevecolor.a < 0.25f)
            {
                Debug.Log(stevecolor);
                test_counter++;
                stevecolor.a += inc_val;
                yield return new WaitForEndOfFrame();
            }

        }
            StartCoroutine(LerpDown());


    }

    public IEnumerator LerpDown()
    {
        cooldown = false;
        Debug.Log(stevecolor);
        while (stevecolor.a > 0f)
        {
            test_counter--;
            stevecolor.a -= inc_val;
            yield return new WaitForEndOfFrame();
        }

    }


}
