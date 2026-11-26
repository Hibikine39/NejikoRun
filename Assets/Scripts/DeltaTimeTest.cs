using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    private float totalTime = 0f;

    private int frameCount = 0;
    void Update()
    {
        if (frameCount > 1f) return;

        totalTime += Time.deltaTime;
        frameCount++;
        Debug.Log($"経過時間:{totalTime}/経過フレーム数{frameCount}");
    }
}
