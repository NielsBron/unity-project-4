using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameToMenu : MonoBehaviour{
    public void LeaveGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
