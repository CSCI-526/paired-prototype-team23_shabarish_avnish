using UnityEngine;
using TMPro;   // if using TextMeshPro

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject winText;   // Drag UI text object here

    void Awake()
    {
        Instance = this;
        winText.SetActive(false);
    }

    public void LevelCleared()
    {
        winText.SetActive(true);
        Time.timeScale = 0f;  // freeze game
    }
}
