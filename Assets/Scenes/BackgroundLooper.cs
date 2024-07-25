using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLooper : MonoBehaviour
{
    public float speed = 0.5f;
    public float resetDistance = 10f;  // ここでリセットする距離を指定
    private Vector3 startPosition;
    private float traveledDistance = 0f;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movementThisFrame = speed * Time.deltaTime;
        transform.Translate(Vector3.left * movementThisFrame);
        traveledDistance += movementThisFrame;

        // traveledDistanceがresetDistanceに達したかどうかをチェック
        if (traveledDistance >= resetDistance)
        {
            transform.position = startPosition;  // 位置をリセット
            traveledDistance = 0f;  // 移動距離をリセット
        }
    }
}
