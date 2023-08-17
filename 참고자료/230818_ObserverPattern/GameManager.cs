using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DesignPattern.SingletonPattern;

public class GameManager : Singleton<GameManager>
{
    public Player Player { get; set; }

    private void Awake() 
    {
        base.Init();
    }
}
