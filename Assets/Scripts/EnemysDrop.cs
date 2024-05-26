using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class EnemysDrop : MonoBehaviour
{
    [SerializeField] private List<GameObject>items;
    private float timer;
    private float totalTimer;
    private int index;
    private int collectionIndex;

    private void Update()
    {
        Spawn();
    }
    void Spawn()
    {
        
        
    }

}
