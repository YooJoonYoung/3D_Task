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
   // [Serializable]
  //  public class ItemDataConsumbale
 //   {
  //      public float value;
 //   }

    [CreateAssetMenu(fileName = "Item", menuName = "New Item")]

    public class ItemData : ScriptableObject
    {
        [Header("Info")]
        public string displayName; //�̸�
        public string description; //����
        public ItemType type; //Ÿ��
        public Sprite icon; //������
        public GameObject dropPrefab; //���������

        [Header("Stacking")]
        public bool canStack; //���ð��ɿ���
        public int maxStackAmount; //�ִ뽺�ü�

        [Header("Equip")]
        public GameObject equipPrefab; //���

        [Header("Consumable Data")]
        public float value;

}



