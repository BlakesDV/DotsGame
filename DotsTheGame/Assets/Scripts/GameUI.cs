using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;
    private bool hasCollidedWithWall = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Muelto");
            //hasCollidedWithWall = true;
            ShowRestartButton();
        }
    }

    public void ShowRestartButton()
    {
        restartButton.SetActive(true);
    }
}
