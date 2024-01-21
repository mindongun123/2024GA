using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // public GameObject _enemyPrefab;

    private void Awake()
    {
        SingletonComponent<Addressable>.Instance.CreateAsset<GameObject>("Assets/DesignPartten/Addressables/Enemy.prefab", _enemyPrefab =>
    {
        Debug.Log("Prefab loaded successfully!");
        Instantiate(_enemyPrefab); // Ví dụ: Instantiate prefab
    },
    () =>
    {
        Debug.LogError("Failed to load prefab!");
    });
    }
}
