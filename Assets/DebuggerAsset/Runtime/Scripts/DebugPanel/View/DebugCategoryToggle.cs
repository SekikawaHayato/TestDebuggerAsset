using System;
using UnityEngine;
using UnityEngine.UI;

namespace DebuggerAsset
{
    [Serializable]
    public class DebugCategoryToggle
    {
        [SerializeField] private Toggle toggle;
        [SerializeField] private GameObject content;


        public Toggle Toggle => toggle;
        public GameObject Content => content;
    }
}
