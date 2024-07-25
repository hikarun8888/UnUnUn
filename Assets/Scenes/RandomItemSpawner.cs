using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{
    public GameObject[] itemPrefabs; // 配置するアイテムのプレハブの配列
    public int itemCount = 10;       // 配置するアイテムの数
    public Vector2 spawnAreaMin;     // スポーンエリアの左下の座標
    public Vector2 spawnAreaMax;     // スポーンエリアの右上の座標
    public Vector2 itemScaleMin = new Vector2(1, 1); // 最小スケール
    public Vector2 itemScaleMax = new Vector2(1, 1); // 最大スケール

    private void Awake()
    {
        SpawnItems();
    }

    public void SpawnItems()
    {
        for (int i = 0; i < itemCount; i++)
        {
            SpawnItem();
        }
    }

    public void SpawnItemsInEditor()
    {
        for (int i = 0; i < itemCount; i++)
        {
            SpawnItem();
        }
    }

    void SpawnItem()
    {
        // ランダムな位置を計算
        float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        Vector2 spawnPosition = new Vector2(x, y);

        // ランダムなアイテムを選択
        int randomIndex = Random.Range(0, itemPrefabs.Length);
        GameObject itemPrefab = itemPrefabs[randomIndex];

        // アイテムを生成
        GameObject spawnedItem = Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
        spawnedItem.transform.SetParent(this.transform);

        // ランダムなスケールを設定
        float scaleX = Random.Range(itemScaleMin.x, itemScaleMax.x);
        float scaleY = Random.Range(itemScaleMin.y, itemScaleMax.y);
        spawnedItem.transform.localScale = new Vector3(scaleX, scaleY, 1);
    }
}
