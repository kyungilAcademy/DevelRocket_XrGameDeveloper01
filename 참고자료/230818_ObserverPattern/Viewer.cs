using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DesignPattern.ObserverPattern;

public class Viewer : MonoBehaviour, IObserver
{
    private Player _player;

    private void Start() 
    {
        _player = GameManager.Instance.Player;
        _player.StatChange.AddObserver(this);
    }

    private void OnDestroy() 
    {
        _player.StatChange.RemoveObserver(this);
    }

    public void OnNotify()
    {
        RefreshData();
    }

    private void RefreshData()
    {
        Debug.Log($"{gameObject.name} : 플레이어 능력치 변화 감지! {_player.Hp}");
    }
}
