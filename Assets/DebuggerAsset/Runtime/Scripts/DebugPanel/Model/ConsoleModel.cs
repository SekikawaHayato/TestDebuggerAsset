using System;
using System.Linq;
using UnityEngine;

namespace DebuggerAsset
{
    public class ConsoleModel
    {
        public string LogText { get; }
        public string StackTrace { get; }
        public string StackFirstLine { get; }
        public Color LogColor { get; }

        public ConsoleModel(string logText, string stackTrace, LogType logType)
        {
            LogText = logText;
            StackTrace = stackTrace;
            StackFirstLine = stackTrace
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                .FirstOrDefault();
            LogColor = logType switch
            {
                LogType.Warning => Color.yellow,
                LogType.Log => Color.white,
                _ => Color.red
            };
        }
    }
}
