using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DebuggerAsset
{
    public class ConsoleScrollList : ScrollRect
    {
        [SerializeField] private ConsoleNode prefab;
        private List<ConsoleNode> allNodes = new List<ConsoleNode>();
        public event Action<ConsoleModel> OnClickNode;

        public void SetLog(ConsoleModel model)
        {
            ConsoleNode node = Instantiate(prefab, content);
            node.Initialize(model, model => OnClickNode?.Invoke(model));
            allNodes.Add(node);
        }

        public void Clear()
        {
            int count = allNodes.Count;
            for(int i = count - 1; i >= 0; i--)
            {
                Destroy(allNodes[i].gameObject);
                allNodes.RemoveAt(i);
            }
        }
    }
}
