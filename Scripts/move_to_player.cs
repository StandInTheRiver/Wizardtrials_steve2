using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_to_player : MonoBehaviour
{
    public Transform player;
    public djinn_take_damage enemy_dmg_script;
    public left_right facedir;
    public float startMovingDistance;
    public float speed;
    public enemy_backoff enemy_backoff;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (enemy_dmg_script.cooldown == false)
        {
            djinn_alive();
        }
    }


    void djinn_alive()
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

        if (enemy_backoff.oncooldown == false)
        {
            if (Vector2.Distance(transform.position, player.position) < startMovingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
        }
    }

}
