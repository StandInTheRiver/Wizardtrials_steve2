using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_move_forward : MonoBehaviour
{
    public Transform player;
    public float startMovingDistance;
    public Transform Ledge;
    public Transform stop1;
    public Transform stop2;
    public Transform stop3;
    public Transform stop4;
    public float speed;
    public bool playerinrange = false;
    public bool stop_moving = false;
    public Transform current_target;
    public float current_speed;
    public Boss_takes_damage boss_health_script;
    public int previous_health;
    public float time_spent_at_spot;
    public float boss_timer = 1f;
    public float elapsedtimer;
    public int checkpointnum;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public GameObject zombie;
    public float spawntimer1;
    public float spawntimer2;
    public float spawntimer3;
    public bool spawn_not_started = true;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        current_target = stop1;
        current_speed = speed;
        InvokeRepeating("spawn_minion1", 1f, spawntimer1);
        InvokeRepeating("spawn_minion2", 3f, spawntimer2);
        InvokeRepeating("spawn_minion3", 7f, spawntimer3);

    }

    // Update is called once per frame
    //if playerinrange started and stopmoving is not set
    //move toward the current target at the current speed
    void Update()
    {
        elapsedtimer = Time.time;
        //only check the player until we start
        if (playerinrange == false)
        {
            check_player();
        }

        //if encounter started and we can move
        if (playerinrange == true && stop_moving == false)
        {
            //constantly check to see if were at our next stop point when moving
            stop_at_ledge(); //this will eentually call a stop, ;eaving this loop

            //move the boss forward
            move_forward(current_target, current_speed);
        }

        //turn on stop_moving when hp is lost

        //if boss lost 25 percent or more of hp
        //start moving again to the next target

        //check boss current health constantly while we are not moving
        if (stop_moving == true)
        {
            check_boss_health();
        }

    }



    void check_boss_health()
    {



        if (current_target == stop2)
        {
            if (boss_health_script.enemy_current_hp <= 75 || (Time.time - time_spent_at_spot) >= boss_timer)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                stop_moving = false;
            }
        }

        if (current_target == stop3)
        {
            if (boss_health_script.enemy_current_hp <= 50 || (Time.time - time_spent_at_spot) >= boss_timer)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                stop_moving = false;
            }
        }

        if (current_target == stop4)
        {
            if (boss_health_script.enemy_current_hp <= 25 || (Time.time - time_spent_at_spot) >= boss_timer)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                stop_moving = false;
            }
        }

        if (current_target == Ledge)
        {
            if ((Time.time - time_spent_at_spot) >= boss_timer)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                stop_moving = false;
            }
        }
    }

    //start encounter
    void check_player()
    {
        if (Vector2.Distance(transform.position, player.position) < startMovingDistance)
        {
            playerinrange = true;
        }
    }


    //move toward current target
    void move_forward(Transform current_target, float current_speed)
    {
        transform.position = Vector2.MoveTowards(transform.position, current_target.position, current_speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("check_point_1"))
        {
            checkpointnum = 1;
        }

        if (other.CompareTag("check_point_2"))
        {
            checkpointnum = 2;
        }

        if (other.CompareTag("check_point_3"))
        {
            checkpointnum = 3;
        }

        if (other.CompareTag("check_point_4"))
        {
            checkpointnum = 4;
        }


    }


    void spawn_minion1()
    {
        //spawn minions at transform
        Instantiate(zombie, spawn1.position, spawn1.rotation);
    }

    void spawn_minion2()
    {
        //spawn minions at transform
        Instantiate(zombie, spawn2.position, spawn2.rotation);
    }

    void spawn_minion3()
    {
        //spawn minions at transform
        Instantiate(zombie, spawn3.position, spawn3.rotation);
    }

    void timer()
    {
        //grab current time
        time_spent_at_spot = Time.time;
    }

    //if we reach the current target, stop, assign next target, assign next speed
    void stop_at_ledge()
    {

        if (checkpointnum == 1)
        {
            if (current_target == stop1)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                //stop moving
                stop_moving = true;
                //set next target
                current_target = stop2;
                //set next speed
                current_speed = current_speed + (speed * 0.25f);
                //start timer
                timer();
            }
        }

        if (checkpointnum == 2)
        {
            //second stop
            if (current_target == stop2)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                //stop moving
                stop_moving = true;
                //set next target
                current_target = stop3;
                //set next speed
                current_speed = current_speed + (speed * 0.25f);
                //start timer
                timer();
            }
        }

        if (checkpointnum == 3)
        {
            //third stop
            if (current_target == stop3)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                //stop moving
                stop_moving = true;
                //set next target
                current_target = stop4;
                //set next speed
                current_speed = current_speed + (speed * 0.25f);
                //start timer
                timer();
            }
        }

        if (checkpointnum == 4)
        {
            //final stop
            if (current_target == stop4)
            {
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
                //stop moving
                stop_moving = true;
                //set next target
                current_target = Ledge;
                //set next speed
                current_speed = current_speed + (speed * 0.25f);
                //start timer
                timer();
            }

        }
    }

}
