using UnityEngine;
using UnityEngine.EventSystems;

namespace DebuggerAsset
{
    public class DebugPanel : MonoBehaviour
    {
        #region Singleton
        private static DebugPanel instance;

        public void Awake()
        {
            if(instance == null)
            {
                instance = this;
                Initialize();
                DontDestroyOnLoad(gameObject);
                return;
            }
            if(instance == this) return;
            Destroy(gameObject);
        }
        #endregion Singleton

        private const float LongTapTime = 3f;
        [SerializeField] private GameObject panelObject;
        [SerializeField] private EventTrigger onOffButtonEvent;
        [SerializeField] private CanvasGroup button;

        [SerializeField] private DebugPanelTopPresenter rootPresenter;

        private float downTime;
        private bool isShowButton;

        private void Initialize()
        {
            rootPresenter.Initialize();
            isShowButton = true;
            panelObject.SetActive(false);

            Subscribe();
        }

        private void Subscribe()
        {
            EventTrigger.Entry downEntry = new EventTrigger.Entry();
            downEntry.eventID = EventTriggerType.PointerDown;
            downEntry.callback.AddListener(OnButtonDown);
            onOffButtonEvent.triggers.Add(downEntry);

            EventTrigger.Entry upEntry = new EventTrigger.Entry();
            upEntry.eventID = EventTriggerType.PointerUp;
            upEntry.callback.AddListener(OnButtonUp);
            onOffButtonEvent.triggers.Add(upEntry);
        }

        private void OnButtonDown(BaseEventData data)
        {
            downTime = Time.time;
        }

        private void OnButtonUp(BaseEventData data)
        {
            if(Time.time > downTime + LongTapTime)
            {
                isShowButton = !isShowButton;
                button.alpha = isShowButton ? 1 : 0;
            }
            panelObject.SetActive(!panelObject.activeSelf);
        }
    }
}
