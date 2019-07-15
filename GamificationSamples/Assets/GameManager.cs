using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUitting Game");
        Application.Quit();
    }
}
