using System.Collections;
using System.Collections.Generic;
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

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetData(Game game)
    {
        IndexText.text = game.id.ToString();
        BetImage.sprite = game.guessed == 0? TailImage : HeadImage;
        CameUpImage.sprite = game.actual == 0 ? TailImage : HeadImage;
        
    }
}
