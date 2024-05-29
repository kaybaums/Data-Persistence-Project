using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;



#if UNITY_EDITOR
using UnityEditor;
#endif
// UnityEditor is not included in a player build

public class UIMenuHandler : MonoBehaviour
{

    public TextMeshProUGUI bestScoreText;
    //public InputField playerNameField;

    public string playerName;

    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.Instance.LoadHighScore();
        bestScoreText.text = "Best Score: " + ScoreManager.Instance.playerName + " : " + ScoreManager.Instance.score;
        
    }

    public void StartNew()
    {
        // do not load scene if player has not entered a name
        if (playerName != null)
        {
            
            SceneManager.LoadScene(1);
        }
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void GetPlayerName(string input)
    {
        playerName = input;
        ScoreManager.Instance.currentPlayer = playerName;
    }
}
