using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public GroundDetect groundDetection;
    public GameObject playerAvatar; 
    
    private float force = 10; 
    
    private readonly float step = 5f;
    private readonly float minHeight = -20;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
           this.MoveLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.Space) && this.groundDetection.isGround)
        {
            this.rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }

        if (transform.position.y < this.minHeight)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void MoveLeft()
    {
        this.transform.localPosition -= this.getPosition();
        if (this.playerAvatar)
        {
            this.playerAvatar.transform.localScale = new Vector3(-1, 1, 1);   
        }
    }
    
    private void MoveRight()
    {
        this.transform.localPosition += this.getPosition();
        if (this.playerAvatar)
        {
            this.playerAvatar.transform.localScale = new Vector3(1, 1, 1);   
        }
    }

    private Vector3 getPosition()
    {
        return this.step * Vector3.right * Time.deltaTime;
    }
}
