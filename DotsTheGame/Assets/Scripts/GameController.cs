using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GameUI))]

public class GameController : MonoBehaviour
{
    public GameUI[] levels; // Array de niveles
    public ScriptablesObjects patron; // Array de niveles
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
        Debug.Log("Cargando nivel: " + levels[levelIndex].levelName);
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            hasCollidedWithWall = true;
            ShowRestartButton();
        }
    }

    public void RestartGame()
    {
        //restart the scene by reloading the currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
