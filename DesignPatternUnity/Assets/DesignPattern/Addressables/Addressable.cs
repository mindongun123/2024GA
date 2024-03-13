using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Addressable : SingletonComponent<Addressable>
{
    public readonly Dictionary<string, AsyncOperationHandle> dicAsset = new Dictionary<string, AsyncOperationHandle>();

    public void CreateAsset<T>(string key, Action<T> onComplete, Action onFailes = null)
    {
        if (dicAsset.ContainsKey(key))
        {
            onComplete?.Invoke((T)dicAsset[key].Result);
        }
        else
        {
            StartCoroutine(LoadAsset(key, onComplete, onFailes));
        }
    }

    IEnumerator LoadAsset<T>(string key, Action<T> onComplete, Action onFailes)
    {
        var opHandle = Addressables.LoadAssetAsync<T>(key);
        yield return opHandle;
        if (opHandle.Status == AsyncOperationStatus.Succeeded)
        {
            onComplete?.Invoke(opHandle.Result);
            if (dicAsset.ContainsKey(key))
            {
                RemoveAsset(key);
            }
            dicAsset[key] = opHandle;
        }
        else if (opHandle.Status == AsyncOperationStatus.Failed)
        {
            Debug.LogError($"Load Asset Failed {key}");
            onFailes?.Invoke();
        }
    }

    private void RemoveAsset(string _key)
    {
        Addressables.Release(dicAsset[_key]);
        dicAsset.Remove(_key);
    }
}
