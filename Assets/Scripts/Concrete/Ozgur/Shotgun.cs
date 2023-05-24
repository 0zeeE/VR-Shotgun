using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Shotgun : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float speed = 20f;
 
     public bool isTopLoaded = false;
     public bool isBotLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(FireBullet);
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireBullet(ActivateEventArgs arg)
    {
        if(isTopLoaded)
        {
            GameObject spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = spawnPoint.position;
            spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * speed;
            Destroy(spawnedBullet, 5);
            isTopLoaded = false;
        }
        else if(isTopLoaded ==false && isBotLoaded == true)
        {
            GameObject spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = spawnPoint.position;
            spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * speed;
            Destroy(spawnedBullet, 5);
            isBotLoaded = false;

        }
        
    }

    

    


}
