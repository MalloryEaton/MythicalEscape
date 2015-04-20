using UnityEngine;
using System.Collections;

public class GetClick : MonoBehaviour 
{
    public enum eInteractiveState
    {
           Active, //open
           Inactive //close
    }

    private eInteractiveState state;

    void Start()
    {
        state = eInteractiveState.Inactive;
    }

    void TriggerInteraction()
    {
        switch(state)
        {
            case eInteractiveState.Active:
                GetComponent<Animation>().Play("Closed");
                state = eInteractiveState.Inactive;
                break;
            case eInteractiveState.Inactive:
                GetComponent<Animation>().Play("Open");
                state = eInteractiveState.Inactive;
                break;
            default:
                break;
        }
    }

	void Update () 
    {
	    if(Input.GetMouseButton(0))
        {
            TriggerInteraction();
        }
	}
}
