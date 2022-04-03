using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    private List<CharacterInfo> inventory_list;
    // Start is called before the first frame update



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Load()
    {
        this.inventory_list.Clear();
        foreach (CharacterInfo item in Store.Instance.character_list)
        {
            if (item.GetObtained())
            {
                this.inventory_list.Add(item);
            }

        }

    }

}
