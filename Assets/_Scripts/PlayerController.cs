using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 5.0f;
    public FixedJoystick fixedJoistick;
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        Vector2 finalMoveDir = (Vector2.up * fixedJoistick.Vertical +
                                Vector2.right * fixedJoistick.Horizontal);
        finalMoveDir *= Time.deltaTime * _speed;
        rb.MovePosition((Vector2)transform.position + finalMoveDir);
    }
}