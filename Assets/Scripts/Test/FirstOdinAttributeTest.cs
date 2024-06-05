using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

public class FirstOdinAttributeTest : MonoBehaviour
{
    [Title("Asset Only")] [AssetsOnly] public List<GameObject> assets = new List<GameObject>();
    [AssetsOnly] public GameObject prefab;
    [AssetsOnly] public Material material;
    [AssetsOnly] public Sprite sprite;


    [Title("Scene Object only")] [SceneObjectsOnly]
    public List<GameObject> sceneObjects = new List<GameObject>();

    [SceneObjectsOnly] public MeshRenderer sceneMeshRender;

    [Title("Custom Attribute Test")] public float from;
    public float to;

    [CustomValueDrawer("MyCustomDrawerStatic")]
    public float customDrawerStatic;

    [CustomValueDrawer("MyCustomDrawerDynamic")]
    public float customDrawerDynamic;

    [Title("Delay")] [Delayed] [OnValueChanged("OnValueChange")]
    public int delayValue;

    [Title("DetailInfoBox")] [DetailedInfoBox("Click the detailInfoBox", "Please Input your name")]
    public string name;

    [ShowInInspector]
    public int age
    {
        get { return 10; }
    }

    [Title("GUIColor & Buttons")]
    [Button]
    [GUIColor(0f, 1f, 0f)]
    private void FuckYou()
    {
        Debug.Log("Fuck You!");
    }
    
    
    [PropertyOrder(-2)]
    public int Second;

    [InfoBox("PropertyOrder is used to change the order of properties in the inspector.")]
    [PropertyOrder(-1)]
    public int First;

    [PropertySpace(SpaceBefore = 10f)]
    [BoxGroup("group", ShowLabel = false)]
    public int sex;
    [BoxGroup("group")]
    public int city;
    [BoxGroup("group")]
    public int county;
    
    [Required]
    public GameObject MyGameObject;

    [Required("Custom error message.")]
    public Rigidbody MyRigidbody;

    [InfoBox("Use $ to indicate a member string as message.")]
    [Required("$DynamicMessage")]
    public GameObject GameObject;

    public string DynamicMessage = "Dynamic error message";
    
    

#if UNITY_EDITOR
    public static float MyCustomDrawerStatic(float value, GUIContent label)
    {
        return EditorGUILayout.Slider(label, value, 0f, 10f);
    }

    public float MyCustomDrawerDynamic(float value, GUIContent label)
    {
        return EditorGUILayout.Slider(label, value, this.from, this.to);
    }
#endif

    private void OnValueChange()
    {
        Debug.Log(delayValue);
    }
}