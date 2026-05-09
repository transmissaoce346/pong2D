using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public string winner;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(true);
            gameOverText.text = $"Parabéns! {winner} Wins!";
            Time.timeScale = 0f;
        }

    }


}