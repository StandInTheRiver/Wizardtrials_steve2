using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_take_damage : MonoBehaviour
{
    public Rigidbody2D rb;
    public int enemy_max_hp;
    public int enemy_current_hp;
    public int player_reg_dmg;
    public int player_spc_dmg;
    public int player_proj_dmg;
    public float freeze_dur = 0.5f;
    public Animator anim2;
    public bool cooldown;
    public Animator anim;
    public bool enemydead;
    public CircleCollider2D hitbox;
    public Patrol patrol;
    public BoxCollider2D boxcol;
    public difficulty_settings settings;

    // Start is called before the first frame update
    void Start()
    {
        enemy_max_hp = settings.get_health(difficulty_settings.Enemies.Skeleton);
        enemy_current_hp = enemy_max_hp;
        anim = GetComponent<Animator>();
    }



    IEnumerator Freeze(float freeze_duration)
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        yield return new WaitForSeconds(freeze_duration);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        cooldown = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //freeze location
        if (other.tag == "Player")
        {
            StartCoroutine(Freeze(freeze_dur));
            cooldown = true;
            check_death();
        }

        //take damage
        if (other.tag == "Player_Hitbox_special")
        {
            FindObjectOfType<AudioManager>().Play("skelly_gets_hit");
            anim2.SetTrigger("get_hit");
            Debug.Log("hit detected special");
            StartCoroutine(Freeze(freeze_dur));
            enemy_current_hp -= player_spc_dmg;
            cooldown = true;
            check_death();
        }

        //take damage
        if (other.tag == "Player_Hitbox_regular")
        {
            FindObjectOfType<AudioManager>().Play("skelly_gets_hit");
            anim2.SetTrigger("get_hit");
            Debug.Log("hit detected regular");
            StartCoroutine(Freeze(freeze_dur));
            enemy_current_hp -= player_reg_dmg;
            cooldown = true;
            check_death();
        }

        //take damage
        if (other.tag == "Player_hitbox_projectile")
        {
            anim2.SetTrigger("get_hit");
            StartCoroutine(Freeze(freeze_dur));
            Debug.Log("hit detected projectille");
            enemy_current_hp -= player_proj_dmg;
            cooldown = true;
            check_death();

        }
    }


    void check_death()
    {
        if (enemy_current_hp <= 0)
        {
            enemydead = true;
            patrol.enabled = !patrol.enabled;
            StartCoroutine(Freeze(freeze_dur));
            //disable collider
            cooldown = true;
            Debug.Log("enemy should be dying now");
            enemy_dies(1f);
        }
    }

    public void enemy_dies(float death_timer1)
    {
        FindObjectOfType<AudioManager>().Play("skelly_dies");
        hitbox.enabled = !hitbox.enabled;
        enemydead = true;
        cooldown = true;
        anim.SetBool("diebool", true);
        Debug.Log("enemy destroyed");
        StartCoroutine(Freeze(freeze_dur));
        StartCoroutine(Die(death_timer1));
    }

    IEnumerator Die(float death_timer2)
    {
        rb.gravityScale = 0;
        Destroy(boxcol);
        cooldown = true;
        yield return new WaitForSeconds(death_timer2);
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
