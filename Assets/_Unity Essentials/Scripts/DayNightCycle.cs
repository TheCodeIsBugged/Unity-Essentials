using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayLengthInSeconds = 60f; // Length of one day in seconds
    private float rotationSpeed; // Speed at which the light rotates

    void Start()
    {
        // Calculate rotation speed based on day length
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate the light around the Y-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
