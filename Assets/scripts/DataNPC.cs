using UnityEngine;

namespace Jeremy
{
    /// <summary>
    /// NPC資料
    /// </summary>
    [CreateAssetMenu(menuName = "Jeremy/NPC")]
    public class DataNPC : ScriptableObject
    {
        [Header("NPC要分析的句子")]
        public string[] sentences;
    }
}
