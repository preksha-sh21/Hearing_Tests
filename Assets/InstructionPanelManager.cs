using UnityEngine;

public class InstructionPanelManager : MonoBehaviour
{
    public GameObject[] panels;
    private int currentPanel = 0;

    public void ShowNextPanel()
    {
        if (currentPanel < panels.Length - 1)
        {
            panels[currentPanel].SetActive(false);
            currentPanel++;
            panels[currentPanel].SetActive(true);
        }
        else
        {
            panels[currentPanel].SetActive(false); // Hide last panel when done
        }
    }
}