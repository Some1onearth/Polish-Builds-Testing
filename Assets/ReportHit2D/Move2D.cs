using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
	Rigidbody2D rb;
	public Vector3 velocity;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
	{
		rb.MovePosition( (Vector3)rb.position + velocity * Time.deltaTime);	
	}
}
