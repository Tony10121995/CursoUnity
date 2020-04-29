using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextElementComponent : MonoBehaviour
{

    public Text Color_text;
    public ColorPropetis myColor;

    public void SetNewColorText(ColorPropetis _newColor, ColorPropetis _newColorText)
    {
        Color_text.color = _newColor.color;
        Color_text.text = _newColorText.Name;
        myColor = _newColorText;
    }


}

