using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_anim : MonoBehaviour
{
    public bool oncooldown;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (oncooldown == false)
        {
            StartCoroutine(cooldown(1.2f));
        }
    }


    IEnumerator cooldown(float waitTime)
    {
        oncooldown = true;
        yield return new WaitForSeconds(waitTime);
        Vector3 flip_dir = transform.localScale;
        flip_dir.x *= -1;
        transform.localScale = flip_dir;
        oncooldown = false;


    }

}
