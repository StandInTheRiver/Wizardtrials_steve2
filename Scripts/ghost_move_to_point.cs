using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//POINTS MUST BE on Z AXIS or wont WORK
public class ghost_move_to_point : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform mytransform;
    public bool reached_dest;
    public int next_point;
    public float speed;
    public bool flip;
    public bool stationary = true;

    // Start is called before the first frame update
    void Start()
    {
        mytransform = GetComponent<Transform>();

        if (stationary == true)
        {
            move_point1(point1);
            next_point = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (stationary == true)
        {
            check_move(point1, point2);

            //call move1 repeatatly
            if (next_point == 1)
            {
                move_point1(point1);
            }

            //call move2 repeatatly
            if (next_point == 2)
            {
                move_point1(point2);
            }

        }
    }

    public void check_move(Transform first_point, Transform second_point)
    {

       //if at the first point, move to second point
        if (transform.position == first_point.position)
        {
            if (flip == true)
            {
                Vector3 flip_dir = transform.localScale;
                flip_dir.x = 1;
                transform.localScale = flip_dir;
            }

            Debug.Log("checkmove if statement valid = firstpos");
            next_point = 2;
        }

        //if at the second point, move to first point
        if (transform.position == second_point.position)
        {
            if (flip == true)
            {
                Vector3 flip_dir = transform.localScale;
                flip_dir.x = -1;
                transform.localScale = flip_dir;
            }
            Debug.Log("checkmove if statement valid = secondpos");
            next_point = 1;
        }
    }

    void move_point1(Transform first_point)
    {
        transform.position = Vector2.MoveTowards(transform.position, first_point.position, speed * Time.deltaTime);
    }

    void move_point2(Transform second_point)
    {
        transform.position = Vector2.MoveTowards(transform.position, second_point.position, speed * Time.deltaTime);
    }


}
