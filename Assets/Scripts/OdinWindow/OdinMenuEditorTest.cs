using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class OdinMenuEditorTest : OdinMenuEditorWindow
{
    [MenuItem("MyWindow/OdinMenuWindow")]
    private static void OpenWindow()
    {
        GetWindow<OdinMenuEditorTest>().Show();
    }
    
    protected override OdinMenuTree BuildMenuTree()
    {
        var tree=new OdinMenuTree();
        tree.Selection.SupportsMultiSelect = false;
        
        tree.Add("Setting",GeneralDrawerConfig.Instance);
        tree.Add("Utilities",new TextureUtilityEditor());
        tree.AddAllAssetsAtPath("Odin Settings", "Assets/Plugins/Sirenix", typeof(ScriptableObject), true, true);
        tree.AddAssetAtPath("OdinMenuEditorTest", "Assets/Scripts/OdinWindow/OdinMenuEditorTest.cs");
        tree.AddAssetAtPath("OdinWindow", "Assets/Scripts/OdinWindow/OdinWindow.cs");
        return tree;
    }
}

public class TextureUtilityEditor
{
    [BoxGroup("Tool"),HideLabel,EnumToggleButtons]
    public Tool Tool;

    public List<Texture> Textures;

    [Button(ButtonSizes.Large),HideIf("Tool",UnityEditor.Tool.Rotate)]
    public void SomeActions(){}
    
    [Button(ButtonSizes.Large),ShowIf("Tool",UnityEditor.Tool.Rotate)]
    public void SomeOtherAction(){}
}