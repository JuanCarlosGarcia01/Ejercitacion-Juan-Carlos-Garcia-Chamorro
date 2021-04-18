using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{

    Color color;

    [MenuItem("Window/Colorizador")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Colorizador");
    }


    void OnGUI()
    {
        GUILayout.Label("Seleccione un objeto para colorearlo", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("COLOREAR"))
        {
            Coloreador();
        }
    }

    void Coloreador()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }

}
