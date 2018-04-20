// Color field attribute V.0.1
// Created by: Wessel Frijters.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FieldColors
{
    Red,
    Orange,
    Yellow,
    Green,
    Cyan,
    Blue,
    Magenta,
    Grey
}

public class ColorAttribute : PropertyAttribute {

    private Color m_Color;

    public ColorAttribute(float r, float g, float b)
    {
        m_Color = new Color(r / 255, g / 255, b / 255);
        m_Color.a = 1f;
    }

    public ColorAttribute(FieldColors color)
    {
        switch (color)
        {
            default:
                m_Color = new Color(0.76f, 0.76f, 0.76f, 1f);
                break;
            case FieldColors.Red:
                m_Color = new Color(1, 0.4f, 0.4f, 1f);
                break;
            case FieldColors.Orange:
                m_Color = new Color(1, 0.7f, 0.4f, 1f);
                break;
            case FieldColors.Yellow:
                m_Color = new Color(1, 1f, 0.4f , 1f);
                break;
            case FieldColors.Green:
                m_Color = new Color(0.4f, 1f, 0.4f, 1f);
                break;
            case FieldColors.Cyan:
                m_Color = new Color(0.4f, 1f, 1f, 1f);
                break;
            case FieldColors.Blue:
                m_Color = new Color(0.4f, 0.4f, 1f, 1f);
                break;
            case FieldColors.Magenta:
                m_Color = new Color(1, 0.4f, 1f, 1f);
                break;
            case FieldColors.Grey:
                m_Color = new Color(0.75f, 0.75f, 0.75f, 1f);
                break;
        }
    }

    public Color color
    {
        get { return m_Color; }
    }

}
