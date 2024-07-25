using UnityEngine;

public class CameraAutoScroll : MonoBehaviour
{
    public float speed = 5.0f;  // スクロールする速度

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);  // X軸に沿ってカメラを移動
    }
}

