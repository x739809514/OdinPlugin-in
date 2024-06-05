using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class OdinButtonTest : MonoBehaviour
{
   public string ButtonName = "dynamic button name";
   public bool toggle;
   public IconButtonGroupExamples iconButtonGroupExamples;

   [Button("$ButtonName")]
   private void DefaultSizeButton()
   {
      this.toggle = !this.toggle;
   }

   [Button("name of button")]
   private void NamedButton()
   {
      this.toggle = !this.toggle;
   }

   [Button(ButtonSizes.Small)]
   private void SmallButton()
   {
      this.toggle = !this.toggle;
   }
   
   [Button(ButtonSizes.Medium)]
   private void MediumButton()
   {
      this.toggle = !this.toggle;
   }

   [DisableIf("toggle")]
   [HorizontalGroup("Split",0.5f)]
   [Button(ButtonSizes.Large), GUIColor(0.4f, 0.8f, 1)]
   private void FanzyButton1()
   {
      this.toggle = !this.toggle;
   }
   
   [DisableIf("toggle")]
   [HorizontalGroup("Split/right")]
   [Button(ButtonSizes.Large), GUIColor(0, 1, 0)]
   private void FanzyButton2()
   {
      this.toggle = !this.toggle;
   }
   
   [Serializable, HideLabel]
   public struct IconButtonGroupExamples
   {
      [ButtonGroup(ButtonHeight = 25), Button(SdfIconType.ArrowsMove, "")]
      void ArrowsMove() { }
    
      [ButtonGroup, Button(SdfIconType.Crop, "")]
      void Crop() { }
   }

   public enum SomeEnum
   {
      first,second,third,fourth
   }

   [Title("Standard Enum")] [EnumToggleButtons,HideLabel]
   public SomeEnum SomeEnumField;


   [InlineButton("A")]
   public int fucktime;

   public void A()
   {
      Debug.Log("fuck you bitch"); }
}
