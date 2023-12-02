using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DebuggerAsset
{
    public class LabelButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Text label;

        public UnityEvent OnClickButton => button.onClick;

        public void SetData(string labelText)
        {
            label.text = labelText;
        }

        public void SetInteractable(bool isInteractable)
        {
            button.interactable = isInteractable;
        }
    }
}
