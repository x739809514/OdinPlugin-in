using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

public class OdinSerializable : SerializedMonoBehaviour
{
    //Odin 不会替换 unity的 serializable
    //如要并存，只能通过以下方式强制使用
    //不建议，会同时保存两份数据，一份odin 一份unity
    [OdinSerialize,NonSerialized]
    public SerializeTest referenceUnity=new SerializeTest();
}

[Serializable]
public class SerializeTest
{
    public Dictionary<int,string> dic_Unity=new Dictionary<int, string>();
}