using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    public float health = 1f;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            health -= 1f;
            if (health <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
