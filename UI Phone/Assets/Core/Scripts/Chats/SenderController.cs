using System;
using Plugins.AltoCityUIPack.Scripts.InputField;
using Plugins.AltoCityUIPack.Scripts.Scrollbar;
using UnityEngine;

namespace Core.Scripts.Chats
{
    [Serializable]
    public class SenderController : MonoBehaviour, ChatsInterfaces
    {
        #region Fields

        [SerializeField] private Message _messagePrefab;
        [SerializeField] private ScrollbarCustomUI _scrollbar;
        [SerializeField] private InputFieldsCustom _inputFields;

        #endregion
        
        public void SendMessage()
        {
            if (string.IsNullOrEmpty(_inputFields.InputFieldText))
            {
                Debug.Log("Input field is empty");
                return;
            }
            
            Message message = Instantiate(_messagePrefab, _scrollbar.Content);
            message.transform.SetAsFirstSibling();
            message.Init(DateTime.Now.ToString("yyyy-MM-dd"),_inputFields.InputFieldText);
            
            ClearInputField();
        }

        private void ClearInputField()
        {
            _inputFields.SetInputField(string.Empty);
        }
    }
}
