using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunShell : MonoBehaviour
{
    public bool isEmpty = false;
    private Vector3 ejectPos;
    private float ejectSpeed = 50f;
    [SerializeField] private float destroyDelay = 4f;
    private Rigidbody shellRB;

    void Start()
    {
        ejectPos = new Vector3(45, 45, 0);
        shellRB = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EjectShell()
    {
        this.gameObject.tag = "EmptyShell";
        shellRB.AddForce(ejectPos * ejectSpeed * Time.deltaTime);
        Destroy(this.gameObject, destroyDelay);
        
    }

    

}
