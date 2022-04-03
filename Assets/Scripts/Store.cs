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

    public CharacterInfo GetPullResult() {
        
        CharacterInfo result = null;

        List<CharacterInfo> HAT_POOL = new List<CharacterInfo>();

        foreach (CharacterInfo item in character_list) 
        {
            for (int i = 0; i < item.drop_rate; i++) //drop_rate indicates how many tokens for the character_info will be in the hat
            {
                HAT_POOL.Add(item);
            }
        }

        result = character_list[Random.Range(0, HAT_POOL.Count)];


        return result;
    
    }
}
