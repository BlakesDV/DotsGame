using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;
    public int levelNumber;
    public string levelName;
    private bool hasCollidedWithWall = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            hasCollidedWithWall = true;
            ShowRestartButton();
        }
    }

    public void ShowRestartButton()
    {
        restartButton.SetActive(true);
    }
}
