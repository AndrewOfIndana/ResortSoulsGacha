using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManagerInstance;
    public int clout;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if (gameManagerInstance == null) 
        {
            gameManagerInstance = this;
        } 
        else
        {
            Destroy(gameObject);
        }
    }

    void MiniGameOneResults(int nClout)
    {
        clout += nClout;
    }
}
