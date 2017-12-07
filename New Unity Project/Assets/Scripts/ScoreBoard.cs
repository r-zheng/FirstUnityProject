using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public int score;
    public int currency;

    private void Awake()
    {
        ChangeScoreBoard();
    }

    public bool SpendCurrency(int amountToSpend)
    {
        if (amountToSpend > currency)
        {
            return false;
        }
        else
        {
            currency -= amountToSpend;
            ChangeScoreBoard();
            return true;
        }
    }

    public void IncreaseScore(int amountScored)
    {
        score += amountScored;
        currency += amountScored;
        ChangeScoreBoard();
        if(score >= 100)
        {
            EndGame(true);
        }
    }

    public void EndGame(bool win)
    {
        if(win)
        {
            Invoke("ShowWin", 2f);
        }
        else
        {
            Invoke("Restart", 2f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowWin()
    {
        SceneManager.LoadScene("WinScreen");
    }

    private void ChangeScoreBoard()
    {
        gameObject.GetComponentInChildren<Text>().text = score.ToString() + "\n" + currency.ToString();
    }
}
