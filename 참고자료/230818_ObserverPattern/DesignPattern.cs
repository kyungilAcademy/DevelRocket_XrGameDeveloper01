using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    namespace ObserverPattern
    {
        public interface IObserver
        {
            public void OnNotify();
        }

        public class Subject
        {
            private List<IObserver> _observers = new List<IObserver>();

            public void AddObserver(IObserver observer)
            {
                _observers.Add(observer);
            }

            public void RemoveObserver(IObserver observer)
            {
                _observers.Remove(observer);
            }

            public void RemoveAll()
            {
                _observers.RemoveAll(x => true);
            }

            public void Notify()
            {
                foreach(IObserver Obs in _observers)
                {
                    Obs.OnNotify();
                }
            }
        }
    }

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
