using UnityEngine;

public class EditorTamaño : MonoBehaviour
{
    public float baseSize = 1f;

    void update()
    {
        float animation = baseSize + Mathf.Sin(Time.time * 8f) * baseSize / 7f;
        transform.localScale = Vector3.one * animation;
    }
}
