using UnityEngine;

public class AlertLights : MonoBehaviour
{
    [SerializeField]
    spriteRenderer redLight;

    [SerializeField]
    spriteRenderer blueLight;

    private float flashSpeed = 4f;
    private bool isAlertActive = false;

    void Start()
    {
        redLight.enabled = false;
        blueLight.enabled = false;
    }

    void Update()
    {
        if (isAlertActive)
        {
            FlashLights();
        }
    }

    public void SetAlert(bool state)
    {
        isAlertActive = state;

        if (!state)
        {
            redLight.enabled = false;
            blueLight.enabled = false;
        }
    }

    private void FlashLights()
    {
        float t = Mathf.PingPong(Time.time * flashSpeed, 1f);
        redLight.enabled = (t > 0.5f);
        blueLight.enabled = (t <= 0.5f);
    }
}
