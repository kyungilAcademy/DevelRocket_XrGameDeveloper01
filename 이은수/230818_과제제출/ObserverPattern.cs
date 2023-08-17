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
}
