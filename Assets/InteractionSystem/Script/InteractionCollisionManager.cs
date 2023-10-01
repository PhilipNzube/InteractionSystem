using UnityEngine;

namespace InteractionSystem.Script
{

    public class InteractionCollisionManager : MonoBehaviour
{
    public GameObject currentInteractable;
    private IInteractionUI interactionUI;


    void Start()
    {
        interactionUI = GetComponent<InteractionUI>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<InteracteeSystem>() != null)
        {
            currentInteractable = other.gameObject;
            interactionUI.PromptTextEnabled();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<InteracteeSystem>() != null)
        {
            currentInteractable = null;
            interactionUI.PromptTextDisabled();
            interactionUI.PromptUI2Disabled();
        }
    }
}
}