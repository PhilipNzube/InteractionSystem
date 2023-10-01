using UnityEngine;

namespace InteractionSystem.Script
{

public class InteracteeSystem : MonoBehaviour, IInteracteeSystem
{
    public string interactionConfigAddressableKey;
    private IInteractionUI interactionUI;
    private IInteractionAddressableLoader IInteractionAL;


    void Start()
    {
        IInteractionAL = GetComponent<IInteractionAddressableLoader>();
        interactionUI = GetComponent<InteractionUI>();
    }


    public void Interact()
    {
        interactionUI.PromptUI2Enabled();
        IInteractionAL.LoadAddressable(interactionConfigAddressableKey);
    }

}
}
