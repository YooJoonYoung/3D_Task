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
    [Serializable]
    public class ItemDataConsumbale
    {
        public float value;
    }

    [CreateAssetMenu(fileName = "Item", menuName = "New Item")]

    public class ItemData : ScriptableObject
    {
        [Header("Info")]
        public string displayName;
        public string description;
        public ItemType type;
        public Sprite icon;
        public GameObject dropPrefab;

        [Header("Stacking")]
        public bool canStack;
        public int maxStackAmount;

      

        [Header("Equip")]
        public GameObject equipPrefab;
    }



