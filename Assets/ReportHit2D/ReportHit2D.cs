using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportHit2D : MonoBehaviour
{
	void OnCollisionEnter2D( Collision2D collision)
	{
		Debug.Log( collision.collider.name + " hit " + collision.otherCollider.name);
	}
}
