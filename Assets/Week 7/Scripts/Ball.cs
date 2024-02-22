using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{
    private Vector3 originalPosition;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = new Vector3(0f, 1f, 0f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag ( "Net"))
        {
            Score();
            transform.position = originalPosition;
            rb.velocity = Vector2.zero;
        }
    }

    public void Score ()
    {
        Controller.score++;
    }

}
