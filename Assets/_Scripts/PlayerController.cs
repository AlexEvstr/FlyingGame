using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 5.0f;
    public FixedJoystick fixedJoistick;
    public Rigidbody2D rb;

    //public void FixedUpdate()
    //{
    //    Vector2 direction = (Vector2.up * fixedJoistick.Vertical + Vector2.right * fixedJoistick.Horizontal);
    //    transform.Translate(direction * Time.deltaTime * _speed);
    //}

    Vector2 MovementDirection; //Assuming this is assigned in Update() from Input
    public float MaxSpeed;
    void FixedUpdate()
    {
        //Vector2 finalMoveDir = MovementDirection.normalized * MaxSpeed;
        Vector2 finalMoveDir = (Vector2.up * fixedJoistick.Vertical + Vector2.right * fixedJoistick.Horizontal);
        //
        //any additional changes to the final direction should happen here
        //
        finalMoveDir *= Time.deltaTime * _speed;
        rb.MovePosition((Vector2)transform.position + finalMoveDir);
    }
}
