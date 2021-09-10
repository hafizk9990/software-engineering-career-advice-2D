using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] Text dynamicGameContent; // goes into empty game object
    [SerializeField] StateLayout startingState; // goes into game object (same as above)
    StateLayout state; // creating object to access public methods in Custom State
    StateLayout[] nextStates; // array container for storing the result of getting next states

    void Start()
    {
        /*
           Remember, Start() is called only once (in the first-ever frame)
        
            In the start, we set just one state (initial state of the game).
            This value is set to the startingState. Everything else will 
            be done in the update method (dynamically)  
        */

        state = startingState;
        dynamicGameContent.text = state.getStateText();
    }

    /*
        Update() is called once every frame
        If there are 60 frames getting rendered per second
        (60 FPS), update() will be called 60 times per second

        We are checking if the user presses 1 or 2 in the update()
        method. Based on that, we go to either the first or the second
        next state
     */

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            updateGameState(0);

        else if (Input.GetKeyDown(KeyCode.Alpha2))
            updateGameState(1);
    }

    /*
        UpdateGameState() is a custom helper. We pass to 
        it the state we need to go to. It checks if that state
        exsits or not in the first place. If it does, we go there

        Notice that we are not really passing state or nextState
        variables, but still they are accessible here, as they are
        globally declared
    */

    void updateGameState(int incomingState)
    {
        nextStates = state.getnextStates();

        if (nextStates.Length >= incomingState + 1)
            state = nextStates[incomingState];

        dynamicGameContent.text = state.getStateText();
    }
}
