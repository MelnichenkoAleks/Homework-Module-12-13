using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private float _timer;

    [SerializeField] private TMP_Text _timerText;

    [SerializeField] private int _victoryCoins;
    private int _coins;

    private bool _isGameOver;

    private void Awake()
    {
        Player player = GetComponent<Player>();
        _isGameOver = false;
        _coins = 0;
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

        if (_coins == _victoryCoins)
            WinGame();

        if (_timer < 5)
            _timerText.color = Color.red;

        if (_timer <= 0)
        {
            _timer = 0;
            LoseGame();
        }
    }

    public void AddCoin(int value)
    {
        _coins += value;

        Debug.Log(_coins);
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
