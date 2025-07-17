using UnityEngine;
using UnityEngine.UI;

public class SanitizerInteraction : MonoBehaviour
{
    public AudioSource squirtAudio;
    public GameObject promptImage; // Canva prompt as GameObject (Image UI)

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Hand") || other.CompareTag("PlayerHand"))
        {
            if (squirtAudio && !squirtAudio.isPlaying)
                squirtAudio.Play();

            if (promptImage != null)
            {
                promptImage.SetActive(true);
                Invoke("HidePrompt", 2f);
            }
        }
    }

    void HidePrompt()
    {
        if (promptImage != null)
            promptImage.SetActive(false);
    }
}
