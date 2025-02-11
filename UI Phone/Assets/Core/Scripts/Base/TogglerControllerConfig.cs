using UnityEngine;

namespace Core.Scripts.Base
{
    public class TogglerPanel : MonoBehaviour
    {
        #region Fields

        [SerializeField] private GameObject _panel;

        #endregion
        
        public void Open()
        {
            _panel.SetActive(true);
        }

        public void Close()
        {
            _panel.SetActive(false);
        }
    }
}
