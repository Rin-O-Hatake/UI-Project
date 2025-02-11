using UnityEngine;

namespace Core.Scripts.Chats
{
    public class ChatController : MonoBehaviour
    {
        #region Fields

        private ChatsInterfaces _senderController;

        #endregion

        public void Inject(ChatsInterfaces controller)
        {
            _senderController = controller;
        }

        #region Buttons

        public void SendChatMessage()
        {
            _senderController.SendMessage();
        }

        #endregion
    }
}
