using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GameUI))]

public class GameController : MonoBehaviour
{
    public GameUI[] levels; // Array de niveles
    private int currentLevelIndex = 0;

    public static GameController Instance { get; private set; }
    [SerializeField] private Vector2 dotsPos;
    [SerializeField] private GameObject dotGO;

    void Start()
    {
        LoadLevel(currentLevelIndex);
    }

    void Update()
    {
        
    }

    void LoadLevel(int levelIndex)
    {
        Debug.Log("Cargando nivel: " + levels[levelIndex]);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Circle"))
        {
            currentLevelIndex++;
            if (currentLevelIndex < levels.Length)
            {
                LoadLevel(currentLevelIndex);
            }
            else
            {             
                Debug.Log("¡Has completado todos los niveles!");
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
