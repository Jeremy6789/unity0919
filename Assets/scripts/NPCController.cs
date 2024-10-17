using UnityEngine;

namespace Jeremy
{
    /// <summary>
    /// NPC控制器
    /// </summary>
    public class NewBehaviourScript : MonoBehaviour
    {
        //序列化欄位 : 將私人變數顯示在Unity屬性面板
        [SerializeField, Header("NPC 資料")]
        private DataNPC dataNPC;

        //Unity的動畫控制系統
        private Animator ani;

        //喚醒事件：播放遊戲時會執行一次
        private void Awake()
        {
                //獲得NPC身上的動畫控制器
                ani = GetComponent<Animator>();
        }
    }
}
  
