using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_backoff : MonoBehaviour
{
    public float cooldown_time;
    public bool oncooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            StartCoroutine(cooldown(cooldown_time));
        }


    }

    IEnumerator cooldown(float cooldown_time)
    {
        oncooldown = true;
        yield return new WaitForSeconds(cooldown_time);
        oncooldown = false;
    }

}
