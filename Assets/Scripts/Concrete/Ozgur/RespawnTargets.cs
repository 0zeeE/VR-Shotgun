using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTargets : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform target1Trans;
    [SerializeField] private Transform target2Trans;
    [SerializeField] private Transform target3Trans;
    [SerializeField] private GameObject targetObjPrefab;
    [SerializeField] private GameObject spawnAble1;
    [SerializeField] private GameObject spawnAble2;
    [SerializeField] private GameObject spawnAble3;
    void Start()
    {
        SpawnTargets();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTargets()
    {
        spawnAble1 = Instantiate(targetObjPrefab, target1Trans);
        spawnAble2 = Instantiate(targetObjPrefab, target2Trans);
        spawnAble3 = Instantiate(targetObjPrefab, target3Trans);

    }

    public void DestroyTargets()
    {
        Destroy(spawnAble1);
        Destroy(spawnAble2);
        Destroy(spawnAble3);
    }

}
