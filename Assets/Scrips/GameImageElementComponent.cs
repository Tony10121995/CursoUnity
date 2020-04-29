using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameImageElementComponent : MonoBehaviour
{
    public Image GameCircle;
    public ColorPropetis myColor;


    public void SetNewColor(ColorPropetis _newColor)
    {
        GameCircle.color = _newColor.color;
        myColor = _newColor;
    }
}