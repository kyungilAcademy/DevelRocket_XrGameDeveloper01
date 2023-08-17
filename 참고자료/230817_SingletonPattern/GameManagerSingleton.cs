using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSingleton : MonoBehaviour
{
    private static GameManagerSingleton _instance;
    public static GameManagerSingleton Instance
    {
        get => _instance;
        private set => _instance = value;
    }

    public int Data = 5;

    private void Awake() 
    {
        Init();
    }

    private void Init()
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
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    
}
