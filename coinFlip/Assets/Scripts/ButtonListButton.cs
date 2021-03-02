using UnityEngine;
using UnityEngine.UI;

public class ButtonListButton : MonoBehaviour
{
    [SerializeField]
    public Text IndexText;
    public Sprite HeadImage;
    public Sprite TailImage;
    public Image BetImage;
    public Image CameUpImage;

    public void SetData(Game game)
    {
        IndexText.text = game.id.ToString();
        BetImage.sprite = game.guessed == 0? TailImage : HeadImage;
        CameUpImage.sprite = game.actual == 0 ? TailImage : HeadImage;
        
    }
}
