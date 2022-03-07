using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public float speed = 2;
    private int direction = -1;
    private Vector3 move;
    void Start()
    {

        move = transform.position;

    }
    void Update()
    {
        move.x += speed * Time.deltaTime;
        transform.position = move;
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "ground")
        {
            speed *= direction;
        }
        if (target.gameObject.tag == "player")
        {
            target.transform.parent = transform;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.transform.parent = null;
        }
    }
}
