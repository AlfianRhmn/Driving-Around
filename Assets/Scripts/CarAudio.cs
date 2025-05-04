using UnityEngine;

public class CarAudio : MonoBehaviour
{
    public AudioSource runningSound;
    public float runningMaxVolume;
    public float runningMaxPitch;
    public AudioSource idleSound;
    public float idleMaxVolume;
    private float speedRatio;

    private CarController carController;
    // Start is called before the first frame update
    void Start()
    {
        carController = GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (carController)
        {
            speedRatio = Mathf.Abs(carController.GetSpeedRatio());
        }

        idleSound.volume = Mathf.Lerp(0.1f, idleMaxVolume, speedRatio);
        runningSound.volume = Mathf.Lerp(0.3f, runningMaxVolume, speedRatio);
        runningSound.pitch = Mathf.Lerp(0.3f, runningMaxPitch, speedRatio);
    }
}