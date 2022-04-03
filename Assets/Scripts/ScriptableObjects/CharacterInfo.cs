using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : ScriptableObject
{
    [Header("Name")]
    public string CharacterName;

    [Header("Pallete")]
    public ReactionPallete reactions;

    [Header("Rarity Info")]
    public int drop_rate; //indicates how many of them we put into a hat.

    public int tier_value; //0 for unremarkable, 1 for uncanny, 2 for unfathomable

   
       
}
