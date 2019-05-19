using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using System;

public class boxesSamples : EditorWindow
{
    [MenuItem("Tools/UIElements/boxesSamples")]
    public static void ShowExample()
    {
        boxesSamples wnd = GetWindow<boxesSamples>();
        wnd.titleContent = new GUIContent("BoxSample���");
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // A stylesheet can be added to a VisualElement.
        // The style will be applied to the VisualElement and all of its children.
        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/Resources/UIElementSamples/BoxesSamples/boxesSamples.uss");
        root.styleSheets.Add(styleSheet);


        //���x���̗v�f���g�����߂̂���
        VisualElement label = new Label("����̓{�b�N�X���g���������T���v���ł��B");
        root.Add(label);

        VisualElement boxHorizontal = new VisualElement
        {
            name = "horizontalBox"
        };

        boxHorizontal.AddToClassList("horizontalContainer");
        boxHorizontal.Add(new VisualElement { style = { backgroundColor = Color.blue } });
        boxHorizontal.Add(new VisualElement { style = { backgroundColor = Color.yellow } });
        boxHorizontal.Add(new VisualElement { style = { backgroundColor = Color.green } });

        root.Add(boxHorizontal);

        Button button = new Button
        {
            text = "�{�^���N���b�N",
        };

        button.clickable.clicked += ()=> { Debug.Log("�{�^����������"); };

        root.Add(button);

        //����I�ȕ�����ǉ�����
        //root.AddManipulator();
    }


}
