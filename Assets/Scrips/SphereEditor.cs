using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EditorTamaño))]
public class FiguraEditor : Editor
{
    
    public override void OnInspectorGUI()
    {
        EditorTamaño figura = (EditorTamaño)target;

        GUILayout.Label("Oscillate around a base size.");

        figura.baseSize = EditorGUILayout.Slider("Size", figura.baseSize, .1f, 8f);

        figura.transform.localScale = Vector3.one * figura.baseSize;
    }
}
