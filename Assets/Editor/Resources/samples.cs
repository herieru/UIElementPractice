using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


public class samples : EditorWindow
{
    [MenuItem("Tools/UIElement/SampleSet")]
    public static void ShowExample()
    {
        samples wnd = GetWindow<samples>();
        wnd.titleContent = new GUIContent("samples");
    }

    public void OnEnable()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        Label label2 = new Label();
        label2.text = "Hello World! From C#";
        root.Add(label2);


        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/Resources/samples.uxml");
        VisualElement labelFromUXML = visualTree.CloneTree();
        root.Add(labelFromUXML);

        // A stylesheet can be added to a VisualElement.
        // The style will be applied to the VisualElement and all of its children.
        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/Resources/samples.uss");
        VisualElement labelWithStyle = new Label("Hello World! With Style");
        labelWithStyle.styleSheets.Add(styleSheet);
        root.Add(labelWithStyle);


        var button = new Button();
        button.text = "aaaa";
        button.styleSheets.Add(styleSheet);
        root.Add(button);


        ScrollView scroll = new ScrollView(ScrollViewMode.Vertical);
    }


}