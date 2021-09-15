using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace ExamplNamespace
{
    public sealed class ExampleClass : ExampleBaseClass
    {
        #region PrivateData

        private enum ExampleEnum
        {
            None   = 0,
            First  = 1,
            Second = 2
        }

        #endregion
        
        
        #region Fields
        
        [Header("Example"), Tooltip("Example"), TextArea(5, 5)] public string ExamplePublicField;
        public Vector3Int ExamplePublicFieldFirst;
        public Vector3 ExamplePublicFieldSecond;
        private const float EXAMPLE_CONST = 0.0f;
        private bool _isExamplePrivateField;
        private int _stat;
        private readonly int _examplePrivateField;

        #endregion


        #region Properties

        public bool IsExamplePrivateField => _isExamplePrivateField;
        private int IsAnotherExamplePrivateField => _examplePrivateField + _stat;

        #endregion
        
        
        #region ClassLifeCycles

        public ExampleClass(int examplePrivateField)
        {
            _examplePrivateField = examplePrivateField;
        }

        #endregion
        

        #region Methods

        protected override void VirtualMethod()
        {
            base.VirtualMethod();
        }

        private void ExampleMethod(ExampleEnum test)
        {
            var exampleList = new List<string>();
            var count = exampleList.Select(s => s.Equals("Test")).Count();
            
            switch (test)
            {
                case ExampleEnum.None:
                    break;
                case ExampleEnum.First:
                    break;
                case ExampleEnum.Second:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(test), test, null);
            }
        }

        #endregion
    }
}
