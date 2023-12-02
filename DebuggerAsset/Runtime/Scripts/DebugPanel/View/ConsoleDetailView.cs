using UnityEngine;
using UnityEngine.UI;

namespace DebuggerAsset
{
    public class ConsoleDetailView : MonoBehaviour
    {
        [SerializeField] private Text logText;

        public void SetData(ConsoleModel model)
        {
            if(model == null)
            {
                logText.text = string.Empty;
                return;
            }
            string text = $"{model.LogText}\n====================\n{model.StackTrace}";
            logText.text = text;
        }
    }
}
