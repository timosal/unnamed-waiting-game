using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void GotoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

