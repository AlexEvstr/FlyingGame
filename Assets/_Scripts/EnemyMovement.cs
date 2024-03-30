using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float _speed = 2.0f;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        //Vector3 finalMoveDir = (Vector3.forward * Time.deltaTime * _speed);

        //rb.MovePosition((Vector3)transform.position + finalMoveDir);
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("border");
        if (collision.gameObject.CompareTag("Border"))
        {
            transform.Rotate(0, 0, 180);
        }
    }
}
