using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using TMPro;
using System.Threading.Tasks;

namespace InteractionSystem.Script
{

    public class InteractionAddressableLoader : MonoBehaviour, IInteractionAddressableLoader
{
    private InteractionUI ObjectUI;
    private InteractionConfig currentTree;

    void Start()
    {
        ObjectUI = GetComponent<InteractionUI>();
    }

    public Task LoadAddressable(string ConfigKey)
    {
        Addressables.LoadAssetAsync<InteractionConfig>(ConfigKey).Completed += OnInteractionConfigLoaded;
        return Task.CompletedTask;
    }

    async void OnInteractionConfigLoaded(AsyncOperationHandle<InteractionConfig> obj)
    {
        await obj.Task;
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            currentTree = obj.Result;
            ObjectUI.DisplayInfo(currentTree);
        }
    }
}
}