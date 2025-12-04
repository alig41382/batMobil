using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public enum BatmanStates { Normal, Stealth, Alert }

    private BatmanStates currentState = BatmanStates.Normal;

    void Update()
    {
        HandleStateSwitch();
    }
    private void HandleStateSwitch()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentState = BatmanStates.Stealth;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = BatmanStates.Alert;
        }
        else if (!Input.GetKey(KeyCode.C) && !Input.GetKey(KeyCode.Space))
        {
            currentState = BatmanStates.Normal;
        }
    }
    public BatmanStates GetBatmanState()
    {
        return currentState;
    }
}
