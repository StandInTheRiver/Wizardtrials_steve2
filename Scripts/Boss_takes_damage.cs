using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_takes_damage : MonoBehaviour
{
    public int enemy_max_hp = 100;
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
    public Boss_move_forward boss_move_forward;
    public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
 
        enemy_current_hp = enemy_max_hp;
        //anim = GetComponent<Animator>();
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        //freeze location
        if (other.tag == "Player")
        {
            //StartCoroutine(Freeze(freeze_dur));
            cooldown = true;
            check_death();
        }

        //take damage
        if (other.tag == "Player_Hitbox_special")
        {
            FindObjectOfType<AudioManager>().Play("boss_gets_hit");
            anim2.SetTrigger("get_hit");
            Debug.Log("hit detected special");
            //StartCoroutine(Freeze(freeze_dur));
            enemy_current_hp -= player_spc_dmg;
            cooldown = true;
            check_death();
        }

        //take damage
        if (other.tag == "Player_Hitbox_regular")
        {
            FindObjectOfType<AudioManager>().Play("boss_gets_hit");
            anim2.SetTrigger("get_hit");
            Debug.Log("hit detected regular");
            //StartCoroutine(Freeze(freeze_dur));
            enemy_current_hp -= player_reg_dmg;
            cooldown = true;
            check_death();
        }

        //take damage
        if (other.tag == "Player_hitbox_projectile")
        {
            anim2.SetTrigger("get_hit");
            Debug.Log("hit detected projectille");
            //StartCoroutine(Freeze(freeze_dur));
            enemy_current_hp -= player_proj_dmg;
            cooldown = true;
            check_death();

        }
    }


    void check_death()
    {
        if (enemy_current_hp <= 0)
        {          
            //disable collider
            cooldown = true;
            Debug.Log("enemy should be dying now");
            enemy_dies(2f);
        }
    }

    public void enemy_dies(float death_timer1)
    {
        FindObjectOfType<AudioManager>().StopPlaying("Boss_theme");
        FindObjectOfType<AudioManager>().Play("post_boss_theme");
        FindObjectOfType<AudioManager>().Play("boss_dies");
        hitbox.enabled = !hitbox.enabled;
        enemydead = true;
        cooldown = true;
        anim.SetBool("diebool", true);
        Debug.Log("enemy destroyed");
        StartCoroutine(Die(death_timer1));
    }

    IEnumerator Die(float death_timer2)
    {
        Debug.Log("boss should die now");
        cooldown = true;
        yield return new WaitForSeconds(death_timer2);
        Destroy(boss);
    }

}
