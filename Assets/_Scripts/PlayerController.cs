using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 5.0f;
    public FixedJoystick fixedJoistick;
    public Rigidbody2D rb;

    public void FixedUpdate()
    {
        //Vector3 direction = Vector3.forward * fixedJoistick.Vertical + Vector3.right * fixedJoistick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime);

        transform.Translate((Vector2.up * fixedJoistick.Vertical + Vector2.right * fixedJoistick.Horizontal) * Time.deltaTime * _speed);
    }
}
