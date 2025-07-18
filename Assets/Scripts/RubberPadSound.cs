using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class RubberPadSound : MonoBehaviour
{
    public AudioSource strikeAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<XRGrabInteractable>() != null)
        {
            if (strikeAudio != null && !strikeAudio.isPlaying)
                strikeAudio.Play();
        }
    }
}
