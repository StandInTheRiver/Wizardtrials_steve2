using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rangesorcerer : MonoBehaviour
{
    public float speed;
    public float startMovingDistance;
    public float stoppingDistance;
    public float retreatDistance;

    private float timeBtwShots;
    public float startTimeBtwShots;
    public left_right facedir;
    public GameObject projectile;
    public Transform fireball_spawn;
    public Transform player;
    public sorc_takes_damage enemy_dmg_script;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = startTimeBtwShots;

    }

    private void Update()
    {

        if (enemy_dmg_script.cooldown == false)
        {
            sorc_alive();
        }

    }


    public void sorc_alive()
    {
        if (facedir.dirNum == 1)
        {
            Vector3 flip_dir = transform.localScale;
            flip_dir.x = -1;
            transform.localScale = flip_dir;
        }

        if (facedir.dirNum == -1)
        {
            Vector3 flip_dir = transform.localScale;
            flip_dir.x = 1;
            transform.localScale = flip_dir;
        }





        if (Vector2.Distance(transform.position, player.position) <= startMovingDistance)
        {

            //transform.position = Vector2.MoveTowards(transform.position, player.position, 0 * Time.deltaTime);


            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
            {
               // transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
               // transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
            {
               // transform.position = Vector2.MoveTowards(transform.position, player.position, 0 * Time.deltaTime);
            }

            if (timeBtwShots <= 0)
            {
                //Quanternion = no rotation for projectile.
                //Instantiate(projectile, transform.position, Quaternion.identity);
                Instantiate(projectile, fireball_spawn.position, fireball_spawn.rotation);
                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }

    }
}
