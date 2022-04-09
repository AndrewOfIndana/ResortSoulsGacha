using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionPallete : ScriptableObject
{
    public Sprite NEUTRAL;
    public Sprite HAPPY;
    public Sprite ANNOYED;
    public Sprite FLUSTERED;


    public Sprite GetSpriteForReaction(ReactionEnum.REACTIONS reaction) 
    {
        Sprite return_val = null;

        switch (reaction) 
        {
            case ReactionEnum.REACTIONS.NEUTRAL:
                return_val = NEUTRAL;
                break;
            case ReactionEnum.REACTIONS.HAPPY:
                return_val = HAPPY;
                break;
            case ReactionEnum.REACTIONS.ANNOYED:
                return_val = ANNOYED;
                break;
            case ReactionEnum.REACTIONS.FLUSTERED:
                return_val = FLUSTERED;
                break;
        }

        return return_val;
    }
    
}
