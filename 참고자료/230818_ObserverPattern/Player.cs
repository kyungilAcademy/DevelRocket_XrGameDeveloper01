using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DesignPattern.ObserverPattern;

public class Player : MonoBehaviour
{
    private int _hp;
    public int Hp
    {
        get => _hp;
        set
        {
            _hp = value;
            Debug.Log($"{gameObject.name} : 스탯 변화!");
            StatChange.Notify();
        }
    }
    public Subject StatChange { get; } = new Subject();

    private void OnEnable() 
    {
        GameManager.Instance.Player = this;
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Hp += 1;
        }
    }

    private void OnDestroy() 
    {
        StatChange.RemoveAll();
    }
}
