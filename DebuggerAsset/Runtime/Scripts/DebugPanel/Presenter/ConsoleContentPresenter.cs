using UnityEngine;
using UnityEngine.UI;

namespace DebuggerAsset
{
    public class ConsoleContentPresenter : ContentPresenterBase
    {
        [SerializeField] private Button clearButton;
        [SerializeField] private ConsoleScrollList scrollList;
        [SerializeField] private ConsoleDetailView detailView;

        public override void Initialize()
        {
            Application.logMessageReceived += OnReceiveLog;
            clearButton.onClick.AddListener(OnClickClearButton);
            scrollList.OnClickNode += SetDetailData;
        }

        private void OnReceiveLog(string logText, string stackTrace, LogType logType)
        {
            scrollList.SetLog(new ConsoleModel(logText, stackTrace, logType));
        }

        private void OnClickClearButton()
        {
            scrollList.Clear();
            detailView.SetData(null);
        }

        private void SetDetailData(ConsoleModel model)
        {
            detailView.SetData(model);
        }
    }
}
