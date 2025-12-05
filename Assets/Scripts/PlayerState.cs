using UnityEngine;

/// <summary>
/// Handles Batman's different states: Normal, Stealth, and Alert.
/// </summary>
public class PlayerState : MonoBehaviour
{
    public enum BatmanStates
    {
        Normal,
        Stealth,
        Alert,
    }

    private BatmanStates currentState = BatmanStates.Normal;

    [SerializeField]
    AlertLights AlertLights;

    void Start()
    {
        currentState = BatmanStates.Normal;
    }

    void Update()
    {
        HandleStateSwitch();
    }

    /// <summary>
    /// Switch between states based on key input.
    /// C -> Stealth
    /// Space -> Alert
    /// V -> Normal
    /// </summary>
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
        else if (Input.GetKeyDown(KeyCode.N))
        {
            currentState = BatmanStates.Normal;
        }

        if (currentState == BatmanStates.Alert)
            AlertLights.SetAlert(true);
        else
            AlertLights.SetAlert(false);
    }

    /// <summary>
    /// Returns the current state of Batman.
    /// </summary>
    public BatmanStates GetBatmanState()
    {
        return currentState;
    }
}
