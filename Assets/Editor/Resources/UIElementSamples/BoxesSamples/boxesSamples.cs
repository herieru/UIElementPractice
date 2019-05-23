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
        if (null != styleSheet)
        {
            root.styleSheets.Add(styleSheet);

        }
        else
        {
            Debug.Log("�X�^�C���V�[�g���擾�ł��Ȃ�");
        }


        //���x���̗v�f���g�����߂̂���
        VisualElement label = new Label("����̓{�b�N�X���g���������T���v���ł��B");
        root.Add(label);

        VisualElement boxHorizontal = new VisualElement
        {
            name = "horizontalBox"
        };
        //�e�L�X�g���������
        VisualElement boxElement = new VisualElement
        {
            name = "textBox"
        };

        boxElement.Add(new Label("����͂����"));
        boxElement.Add(new Button { text = "�������������" });


        boxHorizontal.AddToClassList("horizontalContainer");
        boxHorizontal.Add(boxElement);
        boxHorizontal.Add(new VisualElement { style = { backgroundColor = Color.blue } });
        boxHorizontal.Add(new VisualElement { style = { backgroundColor = Color.yellow } });
        boxHorizontal.Add(new VisualElement { style = { backgroundColor = Color.green } });

        VisualElement boxVertical = new VisualElement
        {
            name = "verticalBox"
        };


        
        boxVertical.Add(new VisualElement { style = { backgroundColor = Color.red } });
        boxVertical.Add(new VisualElement { style = { backgroundColor = Color.yellow } });
        boxVertical.Add(new VisualElement { style = { backgroundColor = Color.white } });
        boxHorizontal.Add(boxVertical);

        root.Add(boxHorizontal);

        Button button = new Button
        {
            text = "�{�^���N���b�N",
        };
        var clickEvent = new ClickEvent();
        clickEvent.target = button;

        button.clickable.clicked   += ()=> { Debug.Log("�{�^����������"); };



        root.Add(button);

        
    }


    public class ClickEvent : MouseManipulator
    {
        protected override void RegisterCallbacksOnTarget()
        {
            Debug.Log("aaa");
        }

        protected override void UnregisterCallbacksFromTarget()
        {
            Debug.Log("bbb");
        }
    }


}
