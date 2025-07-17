using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class TuningForkAudio : MonoBehaviour
{
    public AudioSource pickupAudio;

    private XRGrabInteractable interactable;

    private void OnEnable()
    {
        interactable = GetComponent<XRGrabInteractable>();
        if (interactable != null)
            interactable.selectEntered.AddListener(OnGrab);
    }

    private void OnDisable()
    {
        if (interactable != null)
            interactable.selectEntered.RemoveListener(OnGrab);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (pickupAudio != null && !pickupAudio.isPlaying)
            pickupAudio.Play();
    }
}
