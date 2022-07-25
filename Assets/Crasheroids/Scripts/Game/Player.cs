using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //temporary storage to calculate movement vector
        Vector3 movement;
        //assigns the x axis of the movement vector to match the players' hoizontal input
        movement.x = Input.GetAxisRaw("Horizontal");
        //leave y axis alone as we don't want to be move up and down
        movement.y = Input.GetAxisRaw("Vertical");
        //assigns the z axis of the movement vector to match the player's vertical input
        movement.z = 0;
        //make vector framemate independant
        movement *= Time.deltaTime;
        //apply speed multiplayer
        movement *= speed;

        transform.Translate(movement);

        //Clamp players' position to read inside the field
        Vector3 clampPos = transform.position;
        clampPos.x = Mathf.Clamp(clampPos.x, -10, 10);
        clampPos.z = 0;
        clampPos.y = Mathf.Clamp(clampPos.y, -5, 5);

        transform.position = clampPos;
    }

    public void MoveRight(Vector2 movement)
    {
        //movement code here

    }

    public void MoveLeft(Vector2 movement)
    {

    }

}
