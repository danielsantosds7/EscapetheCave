using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public float speed;
    public float distance=1f;

    bool isRight = true;

    public Transform groundcheck;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right  * speed * Time.deltaTime);
        RaycastHit2D ground = Physics2D.Raycast(groundcheck.position, Vector2.down, distance);

        if(ground.collider == false)
        {
            if (isRight == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRight = true;
            }
        }
    }

    void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;
        Gizmos.DrawLine (transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
    }

		
			
		
}
