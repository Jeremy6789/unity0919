using UnityEngine;

namespace Jeremy
{
    /// <summary>
    /// NPC���
    /// </summary>
    [CreateAssetMenu(menuName = "Jeremy/NPC")]
    public class DataNPC : ScriptableObject
    {
        [Header("NPC�n���R���y�l")]
        public string[] sentences;
    }
}
