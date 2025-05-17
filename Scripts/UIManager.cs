using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameManager gameManager;

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void OnRestart()
    {
        gameManager.Restart();
    }
}
