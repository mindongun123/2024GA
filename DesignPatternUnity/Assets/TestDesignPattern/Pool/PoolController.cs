using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MJGame.TestPool
{
    public class PoolController : MonoBehaviour
    {
        public Queue<ObjectPool> objectPools = new Queue<ObjectPool>();
        public GameObject poolPrefab;
        private void OnEnable()
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject nsn = Instantiate(poolPrefab);
                ObjectPool obj = nsn.GetComponent<ObjectPool>();
                obj.SetObject(this);
                obj.gameObject.SetActive(false);
                objectPools.Enqueue(obj);
            }
        }

        [ContextMenu("Demo")]
        public void DemoPooling()
        {
            StartCoroutine(DelaySpawn());
            IEnumerator DelaySpawn()
            {
                yield return new WaitForSeconds(0.3f);
                ObjectPool obj = objectPools.Dequeue();
                obj.gameObject.SetActive(true);
                obj.Move();
                StartCoroutine(DelaySpawn());
            }
        }

        public void AddQueue(ObjectPool objectPool)
        {
            objectPools.Enqueue(objectPool);
        }
    }
}