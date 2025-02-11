using TMPro;
using UnityEngine;

namespace Core.Scripts.Chats
{
    public class Message : MonoBehaviour
    {
        #region Fields

        [SerializeField] private TMP_Text _messageText;
        [SerializeField] private TMP_Text _timeText;

        #endregion

        public void Init(string time, string message)
        {
            _messageText.text = message;
            _timeText.text = time;
        }
    }
}
