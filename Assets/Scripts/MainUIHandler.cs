using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public TextMeshProUGUI nameText;

    // Start is called before the first frame update
    void Start()
    {

        bestScoreText.text = "Best Score: " + ScoreManager.Instance.playerName + " : " + ScoreManager.Instance.score;
        nameText.text = "Current player: " + ScoreManager.Instance.currentPlayer;
    }
    
    public void BackToMenu()
    {

        SceneManager.LoadScene(0);
    }
}
