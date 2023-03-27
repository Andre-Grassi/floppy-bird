using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    [SerializeField] int speed = 10;

    Rigidbody2D rigidBody;

    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move player upwards
        // Modified in the input manager to jump be the mouse 0 input
        if (Input.GetButtonDown("Jump")){
            rigidBody.velocity = new Vector2(0, speed);
        }
    }
}
