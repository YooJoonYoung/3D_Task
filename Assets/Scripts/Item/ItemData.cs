using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public enum ItemType
    {
        Equipable, //도전 기능 장비장착 - 속도증가,점프력 증가
        Consumable,// 소비- 체력회복
        Resource//돌,나무
    }

    public class ItemConsumable
    {
        public float value;
    }
   // [Serializable]
  //  public class ItemDataConsumbale
 //   {
  //      public float value;
 //   }

    [CreateAssetMenu(fileName = "Item", menuName = "New Item")]

    public class ItemData : ScriptableObject
    {
        [Header("Info")]
        public string displayName; //이름
        public string description; //설명
        public ItemType type; //타입
        public Sprite icon; //아이콘
        public GameObject dropPrefab; //드롭프리펩

        [Header("Stacking")]
        public bool canStack; //스택가능여부
        public int maxStackAmount; //최대스택수

        [Header("Equip")]
        public GameObject equipPrefab; //장비

        [Header("Consumable Data")]
        public float value;

}



