using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameObject _gameover;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Enemy"))
        {
            _gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
}