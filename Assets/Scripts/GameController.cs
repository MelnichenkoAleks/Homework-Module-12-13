using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private Coin _coin;

    [SerializeField] private float _timer;
    private float _redTimer = 5f;

    [SerializeField] private TMP_Text _timerText;

    [SerializeField] private int _victoryCoins;

    private bool _isGameOver;

    private void Awake()
    {
        _isGameOver = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        _timerText.text = _timer.ToString("0.00");

        if (Input.GetKeyDown(KeyCode.F))
        {
            RestartScene();
        }

        if (_isGameOver)
            return;

        _timer -= Time.deltaTime;

        if (_wallet.Count == _victoryCoins)
            WinGame();

        if (_timer < _redTimer)
            _timerText.color = Color.red;

        if (_timer <= 0)
        {
            _timer = 0;
            LoseGame();
        }
    }

    private void WinGame()
    {
        Debug.Log("Вы победили!");
        GameOver();
        PuaseGame();
    }

    private void LoseGame()
    {
        Debug.Log("Вы проиграли, попробуйте еще раз");
        GameOver();
        PuaseGame();
    }

    private void GameOver()
    {
        _isGameOver = true;
    }

    private void PuaseGame()
    {
        Time.timeScale = 0;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
