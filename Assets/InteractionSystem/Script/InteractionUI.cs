using TMPro;
using UnityEngine;

namespace InteractionSystem.Script
{

    public class InteractionUI : MonoBehaviour, IInteractionUI
{
    public TextMeshProUGUI interactionPromptText;
    public GameObject UIPrompt;
    public GameObject UIPrompt2;
    private InteractionInputManager interactionInput;
    public TextMeshProUGUI objectNameText;
    public TextMeshProUGUI ObjectMessageText;


    void Start()
    {
        interactionInput = GetComponent<InteractionInputManager>();
    }


    public void PromptText()
    {
        interactionPromptText.text = "Press" + " " + interactionInput.interactionKeys + " " + "to Interact";
    }

    public void PromptUIEnabled()
    {
        UIPrompt.gameObject.SetActive(true);
    }


    public void PromptUIDisabled()
    {
        UIPrompt.gameObject.SetActive(false);
    }


    public void PromptUI2Enabled()
    {
        UIPrompt2.gameObject.SetActive(true);
    }


    public void PromptUI2Disabled()
    {
        UIPrompt2.gameObject.SetActive(false);
    }

    public void PromptTextEnabled()
    {
        interactionPromptText.enabled = true;
    }

    public void PromptTextDisabled()
    {
        interactionPromptText.enabled = false;
    }

    public void DisplayInfo(InteractionConfig iConfig)
    {
        objectNameText.text = iConfig.objectName;
        ObjectMessageText.text = iConfig.ObjectMessage;
    }
}
}