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
    private bool isDrawingLine = false;

    void Start()
    {
        Instance = this;
        LoadLevel(currentLevelIndex);
    }

    IEnumerator DrawLineAndContinue(int levelIndex)
    {
        isDrawingLine = true;
        Debug.Log("Drawing line...");
        yield return new WaitForSeconds(3f);
        isDrawingLine = false;
        Debug.Log("Line drawn!");
        Debug.Log("Loading level: " + levels[levelIndex]);
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
        if (!isDrawingLine && other.CompareTag("Circle"))
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
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
