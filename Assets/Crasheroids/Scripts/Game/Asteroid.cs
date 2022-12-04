using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 1;
    private float maxPosY = -5;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        //move Asteroid down
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.y < maxPosY)
        {
            //Destroy asteroid after reaching off screen.
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameHandler.gamehandler.GameOver();
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameHandler.gamehandler.AsteroidDestroyed();
        }
        Debug.Log(collision.gameObject.name);
    }
}
