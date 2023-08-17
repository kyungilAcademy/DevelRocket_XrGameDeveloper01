using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    namespace SingletonPattern
    {
        public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
        {
            private static T _instance;
            public static T Instance
            {
                get
                {
                    if(_instance == null)
                    {
                        _instance = FindObjectOfType<T>();
                        DontDestroyOnLoad(_instance.gameObject);
                    }
                    return _instance;
                }
            }

            protected void Init()
            {
                if(_instance != null)
                {
                    if(_instance != this)
                    {
                        Destroy(gameObject);
                    }
                }
                else
                {
                    _instance = GetComponent<T>();
                    DontDestroyOnLoad(gameObject);
                }
            }
        }
    }
}
