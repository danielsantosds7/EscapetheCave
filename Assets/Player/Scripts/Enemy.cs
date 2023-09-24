using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   

    public float speed;
    public Rigidbody2D enemyRb;
    private bool faceFlip;


    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }

    private void FlipEnemy()
    {
        if (faceFlip)
        {
            gameObject.transform.rotation = Quaternion.Euler(0,0,0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0,180,0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col != null && !col.collider.CompareTag("Player") && !col.collider.CompareTag("chao"))
        {
            faceFlip = !faceFlip;
        }
        FlipEnemy();
    }
}
