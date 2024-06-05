using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class CollectionScript : SerializedMonoBehaviour
{
    public Dictionary<int, Material> materials = new Dictionary<int, Material>();
    
    [InlineProperty(LabelWidth = 90)]
    public struct MyCustomType
    {
        public int SomeMember;
        public GameObject SomePrefab;
    }
    
    [DictionaryDrawerSettings(KeyLabel = "enum", ValueLabel = "customType")]
    public Dictionary<MyEnum,MyCustomType> CustomTypes=new Dictionary<MyEnum, MyCustomType>();
    
    public enum MyEnum
    {
        dirst,second,third,fourth
    }
}