using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MJGame.TestPool
{
    public class ObjectPool : MonoBehaviour
    {
        public PoolController poolController;
        public ObjectPool(PoolController poolController)
        {
            this.poolController = poolController;
        }

        public void SetObject(PoolController poolController)
        {
            this.poolController = poolController;
        }
        public void Move()
        {
            transform.position = new Vector3(Random.Range(0, 2), Random.Range(0, 2));
            StartCoroutine(Delay());
            IEnumerator Delay()
            {
                yield return new WaitForSeconds(1f);
                EndDestroy();
            }
        }

        private void EndDestroy()
        {
            poolController.AddQueue(this);
            gameObject.SetActive(false);
        }

        private void OnDisable()
        {
            poolController.AddQueue(this);
            gameObject.SetActive(false);
        }

    }
}