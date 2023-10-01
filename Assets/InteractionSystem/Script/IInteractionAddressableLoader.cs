using System.Threading.Tasks;
namespace InteractionSystem.Script
{
    public interface IInteractionAddressableLoader
    {
        Task LoadAddressable(string ConfigKey);
    }
}