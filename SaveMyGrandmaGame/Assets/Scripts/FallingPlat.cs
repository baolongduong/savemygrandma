using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlat : MonoBehaviour
{
    public float timedelay = 1.5f;
    private Rigidbody2D body;
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "player")
        {
            StartCoroutine(Falling());
        }
    }
    IEnumerator Falling()
    {
        yield return new WaitForSeconds(timedelay);
        body.bodyType = RigidbodyType2D.Dynamic;
    }
}
