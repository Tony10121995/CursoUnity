using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button truebtn;
    public Button falsebtn;
    public GameTextElementComponent Gametext;
    public GameImageElementComponent Gamecircle;
    public ScoreHandler ScoreHandler;

    public ColorPropetis[] avaliableColors;



    public void Start()
    {
        ChangeColors();
    }

    public void ChangeColors()
    {
        int randColorGameCircle = Random.RandomRange(0, avaliableColors.Length - 1);
        int randColorGameText = Random.RandomRange(0, avaliableColors.Length - 1);


        Gametext.SetNewColorText(avaliableColors[randColorGameCircle], avaliableColors[randColorGameText]);
        Gamecircle.SetNewColor(avaliableColors[randColorGameCircle]);
    }
    public void CheckAnswer(bool _answer)
    {
        if (Gamecircle.myColor == Gametext.myColor && _answer)
        {
            ScoreHandler.UpdateScore();

        }
        else if (Gamecircle.myColor != Gametext.myColor && !_answer)
        {
            ScoreHandler.UpdateScore();

        }
        else
        {
            ScoreHandler.ColorIcon();
        }


        ChangeColors();
    }


}
