using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UIEditorSample : EditorWindow
{
    [MenuItem("Tools/EditorWindowSampe")]
    public static void open_tool()
    {
        GetWindow<UIEditorSample>();
    }

    private void OnGUI()
    {
        GUILayout.Label("ああああ");
    }
}
