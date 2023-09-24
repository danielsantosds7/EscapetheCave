using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerpush : MonoBehaviour
{

	public float distance = 1f;
	public GameObject button;
	public MovementJoystick joy;

	int dirX = 1;
	int dirY = 0;

	GameObject box;

	void Update()
	{
	
		if (joy && joy.joystickVec.x != 0)
			dirX = Mathf.RoundToInt(joy.joystickVec.x);
		if (joy && joy.joystickVec.y != 0)
			dirY = Mathf.RoundToInt(joy.joystickVec.y);

		Physics2D.queriesStartInColliders = false;
		RaycastHit2D hitX = Physics2D.Raycast(transform.position, Vector2.right * dirX, distance);
		RaycastHit2D hitY = Physics2D.Raycast(transform.position, Vector2.up * dirY, distance);

	
		Debug.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * dirX * distance, Color.red);
		Debug.DrawLine(transform.position, (Vector2)transform.position + Vector2.up * dirY * distance, Color.yellow);

		//Caso nosso raycast em X OU nosso raycast em Y batam em alguma coisa com tag "pushable"...
		if ((
			(hitX.collider != null && hitX.collider.gameObject.tag == "pushable")
			||
			(hitY.collider != null && hitY.collider.gameObject.tag == "pushable")
			)
			&& Input.GetButtonDown("Fire2"))
		{
			//...checamos se a colisão foi em X ou em Y, depois atribuímos a variável BOX ao que colidimos
			if (hitX.collider != null && hitX.collider.gameObject.tag == "pushable")
				box = hitX.collider.gameObject;
			else
				box = hitY.collider.gameObject;

			//alteramos alguns parâmetros na caixa e agora podemos empurrá-la
			box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
			box.GetComponent<FixedJoint2D>().enabled = true;
			box.GetComponent<boxpull>().beingPushed = true;
		}
		else if (Input.GetButtonUp("Fire2") && box)
		{
			box.GetComponent<FixedJoint2D>().enabled = false;
			box.GetComponent<boxpull>().beingPushed = false;
		}

	}
	void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;

		//Desnecessário. comentei.
		Gizmos.DrawLine (transform.position + Vector3.left * distance, transform.position + Vector3.right * distance);
	}
}