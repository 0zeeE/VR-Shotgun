using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TopLoad : MonoBehaviour
{
    [SerializeField] private GameObject ShotgunTop;

    private bool isLoaded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ShotgunShell")
        {
            ShotgunTop.GetComponent<Shotgun>().isTopLoaded = true;
        }
    }
}
