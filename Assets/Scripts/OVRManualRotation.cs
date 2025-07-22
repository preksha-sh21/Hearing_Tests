using UnityEngine;

public class OVRManualRotation : MonoBehaviour
{
    public float rotationSpeed = 45f; // degrees per second

    void Update()
    {
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick); // Right controller joystick

        if (Mathf.Abs(input.x) > 0.1f) // Avoid accidental input
        {
            transform.Rotate(0, input.x * rotationSpeed * Time.deltaTime, 0);
        }
    }
}
