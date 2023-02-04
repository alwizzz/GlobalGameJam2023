using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : Interactable
{
    [SerializeField] static bool validate;
    [SerializeField] private static int itemCount = 0;
    [SerializeField] private static int maxItem = 0;


    public void TakeItemInHand(Item item)
    {
        if(validate && GameMaster.objState != GameMaster.ObjectiveState.SECOND_ROOT)
        {
            print("attempt to do SECOND_ROOT objective when not currently in that state");
            return;
        }

        itemCount++;
        print("itemCount: " + itemCount);
        if(itemCount >= maxItem)
        {
            GameMaster.ProgressObjectiveState(); // go to THIRD_DIALOGUE
        }

        Destroy(item.gameObject);
    }    
}
