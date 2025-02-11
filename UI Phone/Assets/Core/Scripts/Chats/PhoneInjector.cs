using Core.Scripts.Base;
using UnityEngine;
namespace Core.Scripts.Chats
{
    public class PhoneInjector : MonoBehaviour
    {
        #region Field
        
        [SerializeField] private ChatController _chatController;
        [SerializeField] private SenderController _senderController;
        
        #endregion

        public void Awake()
        {
            _chatController.Inject(_senderController);
        }
    }
}
