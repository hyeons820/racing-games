using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStart : MonoBehaviour
{
    public void OnClickRestart()
    {
        SceneManager.LoadScene(0);
    }
}
