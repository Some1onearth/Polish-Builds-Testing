using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float _speed = 5f;
    Vector3 _moveDir;
    [SerializeField] Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        float _moveX = Input.GetAxis("Horizontal");
        //float _moveY = Input.GetAxis("Vertical");
        PlayerMovement(_moveX, 0);
        StayOnScreen();
        
    }


    public void PlayerMovement(float moveX, float moveY)
    {
        _moveDir = new Vector3(moveX, moveY, 0);
        _moveDir *= _speed * Time.deltaTime;
        transform.position += _moveDir;
    }

    public void StayOnScreen()
    {
        if (_camera = null)
        {
            Vector3 _CameraPos = _camera.WorldToViewportPoint(transform.position);
            Vector3 newPos = transform.position;
            _CameraPos.x = Mathf.Clamp(_CameraPos.x, 0, 1);
            newPos = _camera.ViewportToWorldPoint(_CameraPos);
            transform.position = newPos;
        }
    }

 /* public void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (transform.position.x < maxRight)
        {
            transform.position = new Vector3(maxRight, -3.22f, 0);
        }
    }

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < maxLeft)
        {
            transform.position = new Vector3(maxLeft, -3.22f, 0);
        }
    } */
}
