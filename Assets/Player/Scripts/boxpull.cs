using UnityEngine;
using System.Collections;

public class boxpull : MonoBehaviour 
{

		public float defaultMass;
		public float imovableMass;
		public bool beingPushed;
		float xPos;
	    private Rigidbody2D rb;

		public Vector3 lastPos;

		public int mode;
		public int colliding;
	// Use this for initialization
	void Start () 
	{
		rb = gameObject.GetComponent<Rigidbody2D>();

		xPos = transform.position.x;
		
		lastPos = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (mode == 0) 
		{
			if (beingPushed == false) 
			{
				transform.position = new Vector3 (xPos, transform.position.y);
				rb.constraints = RigidbodyConstraints2D.FreezeAll;
			} 
			else
			{
				xPos = transform.position.x;
				rb.constraints = RigidbodyConstraints2D.FreezeRotation;
			}
		} 
		else if (mode == 1) 
		{

			if (beingPushed == false) 
			{
				GetComponent<Rigidbody2D> ().mass=imovableMass;
				GetComponent<Rigidbody>().velocity = Vector3.zero;
			} 
			else 
			{
				GetComponent<Rigidbody2D> ().mass=defaultMass;
				GetComponent<Rigidbody2D> ().isKinematic = false;
			}
					
		}
	}

	
}