using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DesignPattern.SingletonPattern;

public class GameManager : Singleton<GameManager>
{
    public int Data;

    private void Awake() 
    {
        Init();
    }
}
