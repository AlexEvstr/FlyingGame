using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float _speed = 2.0f;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            transform.Rotate(0, 0, 180);
        }
    }
}
