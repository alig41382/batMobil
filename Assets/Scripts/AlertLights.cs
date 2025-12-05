using UnityEngine;

public class AlertLights : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer redLight;

    [SerializeField]
    SpriteRenderer blueLight;

    [SerializeField]
    AudioSource alertAudio;

    private float flashSpeed = 4f;
    private bool isAlertActive = false;

    void Start()
    {
        redLight.enabled = false;
        blueLight.enabled = false;
        if (alertAudio != null)
            alertAudio.Stop();
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
        if (state)
        {
            if (alertAudio != null && !alertAudio.isPlaying)
                alertAudio.Play();
        }
        else
        {
            redLight.enabled = false;
            blueLight.enabled = false;
            if (alertAudio != null && alertAudio.isPlaying)
                alertAudio.Stop();
        }
    }

    private void FlashLights()
    {
        float t = Mathf.PingPong(Time.time * flashSpeed, 1f);
        redLight.enabled = (t > 0.5f);
        blueLight.enabled = (t <= 0.5f);
    }
}
