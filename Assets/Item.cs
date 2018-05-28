using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Item", menuName = "Item/Item", order = 3)]
public class Item : ScriptableObject
{
    public string Name;
    public float Damage;
    public int Koster;
    public Sprite sprite;

}