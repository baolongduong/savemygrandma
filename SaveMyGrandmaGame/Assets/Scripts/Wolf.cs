using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    public float speed = 4f;
    public GameObject bullet;
    [SerializeField]
    private GameObject effect;


    // Update is called once per frame
    void Update()
    {
        Move();
        //        Attack();
    }

    void Move()
    {
        Vector2 temp = transform.position;
        temp.x -= speed * Time.deltaTime;

        transform.position = temp;
    }

    void Attack()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "left")
        {

            speed = -speed;
            Vector2 scale = transform.localScale;
            scale.x = -1f;
            transform.localScale = scale;

        }
        if (collision.gameObject.tag == "right")
        {
            speed = -speed;
            Vector2 scale = transform.localScale;
            scale.x = 1f;
            transform.localScale = scale;

        }
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
            Destroy(Instantiate(effect, transform.position, this.transform.rotation), 2);
        }
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "left")
        {

            speed = -speed;
            Vector2 scale = transform.localScale;
            scale.x = -1f;
            transform.localScale = scale;
            Debug.Log("Left");
        }
        if (collision.gameObject.tag == "right")
        {
            speed = -speed;
            Vector2 scale = transform.localScale;
            scale.x = 1f;
            transform.localScale = scale;
            Debug.Log("Left");
        }
    }

}
