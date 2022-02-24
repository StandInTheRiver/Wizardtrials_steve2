using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 1;
    public float startMovingDistance;

    public Transform player;
    public Vector2 target;
    public GameObject OriginalObject;
    public SpriteRenderer sprite;
    public Rigidbody2D rb;
    public float closeDistance = 5;
    public Transform enemy;
    public float max_range;
    public left_right facedir;
    public int flip_dir;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //this.sprite = GetComponent<SpriteRenderer>();
        target = new Vector2(player.position.x, player.position.y);
        // rb.velocity = target * speed;
        //this.sprite.flipX = player.transform.position.x > this.transform.position.x;

        Invoke("flip", 0.05f);
        Invoke("kill", 6f);
        enemy = GameObject.FindGameObjectWithTag("enemy").transform;

        rb.velocity = (player.position - transform.position).normalized * speed;

    }

    void flip()
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
    }


    private void Update()
    {

        //rb.velocity = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        // transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //if (Vector2.Distance(transform.position, player.position) < startMovingDistance)
        //  {
        //GameObject clone = (GameObject)GameObject.Instantiate(OriginalObject);
        //    this.GetComponent<Renderer>().enabled = true;

        //rb.velocity = target * speed;
        //     transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //if (transform.position.x == target.x && transform.position.y == target.y)
        //{
        // gameObject.SetActive(false);
        //StartCoroutine(DestroyProjectile());
        //     DestroyProjectile();
        //}
        //  }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_self_hitbox") )
        {
            Destroy(gameObject);
            // DestroyProjectile();
        }

    }

    void kill()
    {
        if (gameObject)
        {
            Destroy(gameObject);
        }

    }

    //IEnumerator DestroyProjectile()
    void DestroyProjectile()
    {
        //this.GetComponent<Renderer>().enabled = false;
        Destroy(gameObject);
        //Destroy(this.gameObject);

        /*yield return new WaitForSeconds(1);
        gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        Destroy(gameObject);*/
    }

    void destroy_self()
    {
        if (Vector2.Distance(transform.position, player.position) > max_range)
        {
            Destroy(gameObject);
        }
    }

}
