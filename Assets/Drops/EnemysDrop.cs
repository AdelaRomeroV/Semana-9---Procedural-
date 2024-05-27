using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class EnemysDrop : MonoBehaviour
{
    [SerializeField] private Item[] items;
    [ContextMenu("Drop Item")]
    public void DropItem()
    {
        Instantiate(items[Random.Range(0, items.Length)], transform.position, Quaternion.identity);
    }
}
