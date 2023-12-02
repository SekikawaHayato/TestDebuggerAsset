using System.Diagnostics;

public class Debugger
{
    // UnityEditor上のみで出力するログの設定
    [Conditional("UNITY_EDITOR")]
    public static void UnityOnlyLog(object o)
    {
        UnityEngine.Debug.Log(o);
    }

    [Conditional("UNITY_EDITOR")]
    public static void UnityOnlyLogWarning(object o)
    {
        UnityEngine.Debug.LogWarning(o);
    }

    [Conditional("UNITY_EDITOR")]
    public static void UnityOnlyLogError(object o)
    {
        UnityEngine.Debug.LogError(o);
    }

    // ScriptingDefineSymbolsで[DEVELOP]が指定されている時のみ出力するログの設定
    [Conditional("DEVELOP")]
    public static void DevelopmentOnlyLog(object o)
    {
        UnityEngine.Debug.Log(o);
    }

    [Conditional("DEVELOP")]
    public static void DevelopmentOnlyLogError(object o)
    {
        UnityEngine.Debug.LogError(o);
    }

    [Conditional("DEVELOP")]
    public static void DevelopmentOnlyLogWarning(object o)
    {
        UnityEngine.Debug.LogWarning(o);
    }
}
