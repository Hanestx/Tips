using UnityEngine.UI;
using UnityEngine;


namespace ExamplNamespace
{
    public abstract class ExampleBaseClass : MonoBehaviour, IInterfacable
    {
        private Button _button;
        
        #region UnityMethods

        private void Awake()
        {
            _button = FindObjectOfType<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(Example);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(Example);
        }

        #endregion
        

        #region Methods
        
        protected virtual void VirtualMethod()
        {
           
        }

        #endregion
        
        
        #region IInterfacable
        
        public void Example()
        {
            
        }

        #endregion
    }
}
