using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero_projectile : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    GameObject player;
    public float max_range;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        transform.localScale = player.transform.localScale;
        Invoke("kill", 2f);


        if (player.transform.localScale.x == -1)
        {

            rb.velocity = transform.right * -1 * speed;

        }

        if (player.transform.localScale.x == 1)
        {

            rb.velocity = transform.right * speed;

        }

    }



    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Ground"|| other.tag == "boss_hitbox" || other.tag =="Untagged" || other.tag == "enemy" || other.tag == "Melee_Enemy_touch" || other.tag =="Range_Enemy_touch" || other.tag == "vines" || other.tag == "opaque" || other.tag == "non-climb")
        {
            if (gameObject)
            {
                FindObjectOfType<AudioManager>().Play("shot_hits");
                Destroy(gameObject);
            }

        }


    }

        // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) >= max_range)
        {
            if (gameObject)
            {
                kill();
            }
        }
    }


    void kill()
    {
        if (gameObject)
        {
            Destroy(gameObject);
        }

    }
}
