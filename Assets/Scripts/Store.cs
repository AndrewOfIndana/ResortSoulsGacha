using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public static Store Instance { get; private set; }

    [Header("CharacterInfo")]
    [Tooltip("MUST CONTAIN EVERY CHARACTERINFO OBJECT IN THE GAME")]
    public List<CharacterInfo> character_list; //Contains a list of every CharacterInfo object

    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {

            Destroy(this);
        }

        else
        {
            Instance = this;

        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}