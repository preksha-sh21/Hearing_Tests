using UnityEngine;

public class OVRManualMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public Transform vrCamera;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector3 direction = vrCamera.forward * input.y + vrCamera.right * input.x;
        direction.y = 0; // keep movement flat
        controller.Move(direction * moveSpeed * Time.deltaTime);
    }
}