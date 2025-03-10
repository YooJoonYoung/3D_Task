using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public enum ItemType
    {
        Equipable, //���� ��� ������� - �ӵ�����,������ ����
        Consumable,// �Һ�- ü��ȸ��
        Resource//��,����
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



