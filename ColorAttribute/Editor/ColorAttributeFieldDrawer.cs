using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ColorAttribute))]
public class ColorAtributeFieldDrawer : PropertyDrawer {

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Color oldColor = GUI.backgroundColor;
        ColorAttribute colorAttribute = attribute as ColorAttribute;
        GUI.backgroundColor = colorAttribute.color;
        EditorGUI.PropertyField(position, property, label);
        GUI.backgroundColor = oldColor;
    }
}
