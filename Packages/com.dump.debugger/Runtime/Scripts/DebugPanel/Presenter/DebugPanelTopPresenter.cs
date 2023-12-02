using System.Collections.Generic;
using UnityEngine;

namespace DebuggerAsset
{
    public class DebugPanelTopPresenter : MonoBehaviour
    {
        [SerializeField] private DebugCategoryToggleGroup categoryToggleGroup;
        [SerializeField] private List<ContentPresenterBase> presenters;

        public void Initialize()
        {
            categoryToggleGroup.Initialize();
            categoryToggleGroup.OnValueChanged += (index) => { };
            presenters.ForEach(presenter => presenter.Initialize());
        }
    }
}
