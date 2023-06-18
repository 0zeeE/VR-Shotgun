using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTargets : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform target1Trans;
    [SerializeField] private Transform target2Trans;
    [SerializeField] private Transform target3Trans;
    [SerializeField] private Transform target4Trans;
    [SerializeField] private Transform target5Trans;
    [SerializeField] private Transform target6Trans;

    [SerializeField] private GameObject targetObjPrefab;

    [SerializeField] private GameObject spawnAble1;
    [SerializeField] private GameObject spawnAble2;
    [SerializeField] private GameObject spawnAble3;
    [SerializeField] private GameObject spawnAble4;
    [SerializeField] private GameObject spawnAble5;
    [SerializeField] private GameObject spawnAble6;


    void Start()
    {
        SpawnTargets();
    }

    public void SpawnTargets()
    {
        spawnAble1 = Instantiate(targetObjPrefab, target1Trans);
        spawnAble2 = Instantiate(targetObjPrefab, target2Trans);
        spawnAble3 = Instantiate(targetObjPrefab, target3Trans);
        spawnAble4 = Instantiate(targetObjPrefab, target4Trans);
        spawnAble5 = Instantiate(targetObjPrefab, target5Trans);
        spawnAble6 = Instantiate(targetObjPrefab, target6Trans);

    }

    public void DestroyTargets()
    {
        Destroy(spawnAble1);
        Destroy(spawnAble2);
        Destroy(spawnAble3);
        Destroy(spawnAble4);
        Destroy(spawnAble5);
        Destroy(spawnAble6);
    }

}
