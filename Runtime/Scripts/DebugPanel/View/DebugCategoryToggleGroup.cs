using System;
using UnityEngine;
using UnityEngine.UI;

namespace DebuggerAsset
{
    public class DebugCategoryToggleGroup : ToggleGroup
    {
        [SerializeField] private DebugCategoryToggle[] toggles;

        public event Action<int> OnValueChanged;

        private int currentIndex;


        public void Initialize(int startIndex = 0)
        {
            currentIndex = startIndex;

            int length = toggles.Length;
            for(int i = 0; i < length; i++)
            {
                int selectIndex = i;
                bool isOn = i == currentIndex;
                toggles[i].Toggle.group = this;
                toggles[i].Toggle.isOn = isOn;
                toggles[i].Content.SetActive(isOn);

                toggles[i].Toggle.onValueChanged.AddListener(isOn =>
                {
                    toggles[selectIndex].Content.SetActive(isOn);
                    if(isOn)
                    {
                        currentIndex = selectIndex;
                        OnValueChanged?.Invoke(selectIndex);
                    }
                });
            }
        }
    }
}
