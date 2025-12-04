using UnityEngine;

/// <summary>
/// Controls the Bat-Signal: toggle visibility and rotate.
/// </summary>
public class BatSignalController : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 20f;
    private int times = 0;
    private bool isActive;

    [SerializeField]
    private GameObject gb;

    void Start()
    {
        gb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HandleToggle();
        RotateSignal();
    }

    private void HandleToggle()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            times++;
            if (times % 2 == 1)
            {
                // Debug.Log("Bat-Signal activated");
                isActive = true;
                gb.SetActive(isActive);
            }
            else
            {
                // Debug.Log("Bat-Signal deactivated");
                isActive = false;
                gb.SetActive(isActive);
            }
        }
    }

    private void RotateSignal()
    {
        if (isActive)
        {
            gb.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
