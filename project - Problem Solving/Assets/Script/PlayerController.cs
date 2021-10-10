using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //control
    public KeyCode upButton = KeyCode.W;
    public KeyCode downButton = KeyCode.S;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;

    //batasan
    public float speed = 10.0f;
    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
        
        if (Input.GetKey(upButton)) velocity.y = speed; //atas
        else if (Input.GetKey(downButton)) velocity.y = -speed; //kebawah
        else velocity.y = 0.0f; //idle
        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;
        
        if (Input.GetKey(rightButton)) velocity.x = speed; //kekanan
        else if (Input.GetKey(leftButton)) velocity.x = -speed; //kekiri
        else velocity.x = 0.0f; //idle
        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;
    }
}
