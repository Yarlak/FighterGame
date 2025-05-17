using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public UIManager uiManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            uiManager.ShowGameOver();
            Destroy(gameObject);
        }
    }
}
