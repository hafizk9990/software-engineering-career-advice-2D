using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The line below makes this layout available as "Custom State" in Unity

[ CreateAssetMenu(menuName = "Custom State") ]

public class StateLayout : ScriptableObject
{
    // The following two fields will be accessible in empty "Our Game" game object

    [ TextArea(10, 10) ] [SerializeField] string stateText; // private by default
    [ SerializeField ] StateLayout[] nextStatesArray; // private by default

    public string getStateText() // publicly declared. Accessible from other files
    {
        return stateText;
    }

    public StateLayout[] getnextStates() // publicly declared. Accessible from other files
    {
        return nextStatesArray;
    }
}
