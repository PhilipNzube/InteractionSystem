using UnityEngine;

namespace InteractionSystem.Script
{

    [CreateAssetMenu(menuName = "Interaction System/InteactionConfig")]
    public class InteractionConfig : ScriptableObject
    {
        public string objectName;
        public string ObjectMessage;
    }
}
