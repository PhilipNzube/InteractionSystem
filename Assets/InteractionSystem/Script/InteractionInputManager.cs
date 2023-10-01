using UnityEngine;


namespace InteractionSystem.Script
{
    public class InteractionInputManager : MonoBehaviour
{
    public KeyCode interactionKeys;
    private InteractionCollisionManager interactionCollisionManager;
    private IInteractionUI interactionUI;


    void Start()
    {
        interactionCollisionManager = GetComponent<InteractionCollisionManager>();
        interactionUI = GetComponent<InteractionUI>();
        interactionUI.PromptUIDisabled();
    }


    void Update()
    {
        if (interactionCollisionManager.currentInteractable != null)
        {
            interactionUI.PromptUIEnabled();
            interactionUI.PromptText();
            if (Input.GetKeyDown(interactionKeys))
            {
                IInteracteeSystem interactable = interactionCollisionManager.currentInteractable.GetComponent<InteracteeSystem>();
                if (interactable != null)
                {
                    interactionUI.PromptTextDisabled();
                    interactable.Interact();
                }
            }
        }
        else
        {
            interactionUI.PromptUIDisabled();
        }
    }
}
}