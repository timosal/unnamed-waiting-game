using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenGuide : MonoBehaviour
{
    public void GotoGuideScene()
    {
        SceneManager.LoadScene("GuideScene");
    }
}

