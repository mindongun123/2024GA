using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MJGame.TestSingleton
{
    public class SingletonComponent : MonoBehaviour
    {
        // Khoi tao Singleton
        public static SingletonComponent instance;

        // Dang ki Singleton
        private void Awake()
        {
            instance = this;
        }

        // cac thuoc tinh, phuong thuc cua SingletonComponent
        public int _age;
        private string _name= "Singleton";

        public string GetName()
        {
            return _name;
        }
        public void SetName(string _name)
        {
            this._name = _name;
        }
    }
}