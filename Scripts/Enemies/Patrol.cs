using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingLeft = true;
    public Rigidbody2D rb;
    public Transform groundDetection;
    public Enemy_take_damage enemy_dmg_script;
    public LayerMask walllayer;
    public bool walltouch;
    public Transform walltrans;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        walltouch = Physics2D.OverlapCircle(walltrans.position, 0.15f, walllayer);

        if (enemy_dmg_script.cooldown == false)
        {
            move_enemy();
        }
    }


    public void move_enemy()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false || walltouch == true)
        {
            if (movingLeft == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingLeft = false;

            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingLeft = true;
            }
        }
    }
}
