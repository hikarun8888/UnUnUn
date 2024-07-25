using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RandomItemSpawner))]
public class ItemSpawnerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        RandomItemSpawner spawner = (RandomItemSpawner)target;
        if (GUILayout.Button("Spawn Items"))
        {
            spawner.SpawnItemsInEditor();
        }
    }
}
