using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_getshit : MonoBehaviour
{
    public Hero_Controls controller;
    public Hero_Controller controller2;
    public Animator anim;
    public int hits_taken;
    public Rigidbody2D playerbod;
    public float knockdur; //how long knocked back
    public Vector2 knockback_dir; //direction of knock back
    public float knockbackpower; //how far you get knocked back
    public Transform player;
    public bool on_cooldown;
    public int player_max_health = 100;
    public int player_current_health;
    private Vector2 total_knock_str;
    public flash_screen flash_screenobject;
    public bool boundary;
    public bool skelly;

    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        player_current_health = player_max_health;
        healthBar.maxValue = player_max_health;
    }


    void get_hit()
    {
        anim.SetTrigger("get_hit");
        StartCoroutine(flash_screenobject.LerpUp());
        StartCoroutine(knockback());
        StartCoroutine(cooldown(0.75f));
    }

    void get_hit_slow()
    {
        anim.SetTrigger("get_hit");
        StartCoroutine(flash_screenobject.LerpUp());
        StartCoroutine(knockback());
        StartCoroutine(cooldown(0.1f));
    }


    void get_hitboss()
    {
        anim.SetTrigger("get_hit");
        StartCoroutine(flash_screenobject.LerpUp());
        StartCoroutine(knockback());
        StartCoroutine(cooldown(0.75f));
    }

    IEnumerator cooldown(float waitTime)
    {
        anim.SetBool("get_hitbool", true);
        on_cooldown = true;
        yield return new WaitForSeconds(waitTime);
        on_cooldown = false;
        anim.SetBool("get_hitbool", false);
        skelly = false;
    }


    public IEnumerator knockback()
    {
        float timer = 0;
        knockback_dir.x = player.transform.position.x;
        knockback_dir.y = player.transform.position.y;
        while (knockdur > timer)
        {


            float x = 0;
            float y = 0;
            float xbase =0;
            float ybase =0;
            timer += Time.deltaTime;

            //ifx positive
            if (Mathf.Sign(playerbod.velocity.x) == 1)
            {
                x = -1;
                xbase = -1.5f;
            }

            //ifx negative
            if (Mathf.Sign(playerbod.velocity.x) == -1)
            {
                x = -1;
                xbase = 1.5f;
            }

            //ify positive
            if (Mathf.Sign(playerbod.velocity.y) == 1)
            {
                y = -1;
                ybase = -1.5f;
            }

            //ify negative
            if (Mathf.Sign(playerbod.velocity.y) == -1)
            {
                y = -1;
                ybase = 1.5f;
            }

            total_knock_str.x = xbase + playerbod.velocity.x * x * 2;
            total_knock_str.y = ybase + playerbod.velocity.y * y * 2;


            if (controller2.grounded == true)
            {

                if (total_knock_str.x < 5)
                {
                    float x_add = Mathf.Sign(total_knock_str.x) * 3;
                    total_knock_str.x += x_add;
                }

                if (total_knock_str.y < 5)
                {
                    float y_add = Mathf.Sign(total_knock_str.y) * 3;
                    total_knock_str.y += y_add;
                }
            }

            if (skelly == true && boundary == false)
            {
                playerbod.AddForce(new Vector2(0, 0));
            }

            if (boundary == true)
            {
                playerbod.AddForce(new Vector2(total_knock_str.x * 2, total_knock_str.y * 2));
            }

            if (boundary == false)
            {
                playerbod.AddForce(new Vector2(total_knock_str.x, total_knock_str.y));
            }

            //playerbod.AddForce(new Vector2(knockback_dir.x * -1, knockback_dir.y * -1));

        }
        

        yield return 0;

    }


    void check_death()
    {
        if (player_current_health <= 0)
        {
            Debug.Log("player should be dying now");
            controller.player_dies(1.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (on_cooldown == false)
        {
            boundary = false;

            if (other.tag == "boundary_explosion")
            {
                boundary = true;
                get_hitboss();
                Debug.Log("BOUNDARY HIT----------------------------------");
                hits_taken += 1;
                check_death();
            }

            if (other.tag == "boss_music")
            {
                FindObjectOfType<AudioManager>().StopPlaying("Mountain_theme2");
                FindObjectOfType<AudioManager>().Play("Boss_theme");
            }

            if (other.tag =="skelly_touch")
            {
                FindObjectOfType<AudioManager>().Play("female_scream_med");
                skelly = true;
                get_hit_slow();
                Debug.Log("skelly touch");
                hits_taken += 1;
                player_current_health -= 25;
                check_death();
            }

            if (other.tag == "boss_hitbox")
            {
                FindObjectOfType<AudioManager>().Play("female_scream_med");
                get_hitboss();
                Debug.Log("Melee_Enemy_1 did melee damage");
                hits_taken += 1;
                player_current_health -= 25;
                check_death();
            }

            if (other.tag == "Melee_Enemy_1")
            {
                FindObjectOfType<AudioManager>().Play("female_scream_med");
                get_hit();
                Debug.Log("Melee_Enemy_1 did melee damage");
                hits_taken += 1;
                player_current_health -= 25;
                check_death();
            }
            if (other.tag == "ghost_hit")
            {
                FindObjectOfType<AudioManager>().Play("female_scream_med");
                get_hit();
                Debug.Log("Melee_Enemy_1 did melee damage");
                hits_taken += 1;
                player_current_health -= 10;
                check_death();
            }

            if (other.tag == "Melee_Enemy_touch")
            {
                FindObjectOfType<AudioManager>().Play("female_scream_med");
                get_hit();
                Debug.Log("Melee_Enemy_1 touched player");
                hits_taken += 1;
                player_current_health -= 25;
                check_death();
            }


            if (other.tag == "Range_Enemy_1")
            {
                FindObjectOfType<AudioManager>().Play("female_scream_med");
                get_hit();
                Debug.Log("Range_enemy_1 projectile hit");
                hits_taken += 1;
                player_current_health -= 35;
                check_death();
            }

            if (other.tag == "Range_Enemy_touch")
            {
                FindObjectOfType<AudioManager>().Play("female_scream_med");
                get_hit();
                Debug.Log("Range_enemy_1 touched player");
                hits_taken += 1;
                player_current_health -= 25;
                check_death();
            }

        }

        else return;
    }



    // Update is called once per frame
    void Update()
    {
        healthBar.value = player_current_health;
    }
}
