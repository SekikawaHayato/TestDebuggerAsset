using System;
using UnityEngine;
using UnityEngine.UI;

namespace DebuggerAsset
{
    public class ConsoleNode : MonoBehaviour
    {
        [SerializeField] private Image typeIcon;
        [SerializeField] private Text logText;
        [SerializeField] private Text stackText;
        [SerializeField] private Button button;

        public void Initialize(ConsoleModel model, Action<ConsoleModel> onClickAction)
        {
            typeIcon.color = model.LogColor;
            logText.text = model.LogText;
            stackText.text = model.StackFirstLine;
            button.onClick.AddListener(() => onClickAction?.Invoke(model));
        }
    }
}
