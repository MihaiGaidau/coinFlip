using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public Button TailButton;
    public Button HeadButton;
    public Text ScoreText;
    public Text GameText;
    public Image GameImage;
    public Sprite HeadImage;
    public Sprite TailImage;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString();
        TailButton.onClick.AddListener(TailButtonOnClick);
        HeadButton.onClick.AddListener(HeadButtonOnClick);
    }

    void HeadButtonOnClick()
    {
        PlayGame(1);
    }

    
    void TailButtonOnClick()
    {
        PlayGame(0);
    }

    public void PlayGame(int guessed)
    {
        int randomValue = Random.Range(0, 2);
        GameImage.sprite = randomValue == 0 ? TailImage : HeadImage;
        GameImage.color = randomValue == 0 ? Color.green : Color.red;
        GameText.text = randomValue == guessed ? "TAIL" : "HEAD";
        if (randomValue == guessed)
            score += 100;
        else
            score -= 100;
        ScoreText.text = score.ToString();
        GameHistory.games.Add(new Game { id = GameHistory.games.Count, guessed = guessed, actual = randomValue });

    }

}
