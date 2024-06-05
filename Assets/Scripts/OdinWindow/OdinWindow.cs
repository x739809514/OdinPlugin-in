using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class OdinWindow : OdinEditorWindow
{
    [MenuItem("MyWindow/OdinWindow")]
    public static void OpenWindow()
    {
        GetWindow<OdinWindow>().Show();
    }
    
    public enum ScaleMode
    {
        StretchToFill,ScaleAndCrap,ScaleToFit
    }

    [BoxGroup("Setting")]
    [EnumToggleButtons]
    public ScaleMode scaleMode;

    [BoxGroup("Setting")]
    [FolderPath(RequireExistingPath = true)]
    public string outputPath;

    [HorizontalGroup("Split",0.5f)]
    public List<Texture> inputTexture;
    
    [HorizontalGroup("Split/right"),InlineEditor(InlineEditorModes.LargePreview)]
    public Texture preview;

    [Button(ButtonSizes.Large),GUIColor(0,1,0)]
    public void PerformSomeAction()
    {
        Debug.Log("OdinWindow Test");
    }
}
