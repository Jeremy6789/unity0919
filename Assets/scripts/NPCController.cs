using UnityEngine;

namespace Jeremy
{
    /// <summary>
    /// NPC���
    /// </summary>
    public class NewBehaviourScript : MonoBehaviour
    {
        //�ǦC����� : �N�p�H�ܼ���ܦbUnity�ݩʭ��O
        [SerializeField, Header("NPC ���")]
        private DataNPC dataNPC;

        //Unity���ʵe����t��
        private Animator ani;

        //����ƥ�G����C���ɷ|����@��
        private void Awake()
        {
                //��oNPC���W���ʵe���
                ani = GetComponent<Animator>();
        }
    }
}
  
