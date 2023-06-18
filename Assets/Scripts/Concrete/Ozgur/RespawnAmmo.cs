using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAmmo : MonoBehaviour
{
    [SerializeField] private GameObject ammo;
    [SerializeField] private Transform ammoTransform;
    // Start is called before the first frame update
    void Start()
    {
        ammoTransform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAmmo()
    {
        GameObject shotgunShells = Instantiate(ammo, ammoTransform);
    }
}
