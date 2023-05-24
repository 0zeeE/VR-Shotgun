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
    [SerializeField] private HingeJoint shotgunHinge;
    [SerializeField] private GameObject topSocket;
    [SerializeField] private GameObject botSocket;
    [SerializeField] private GameObject shotgunShell1;
    [SerializeField] private GameObject shotgunShell2;




    void Start()
    {
        
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(FireBullet);
        

        
        
       
    }

    // Update is called once per frame
    void Update()
    {
     
        


        EjectEmptyShells();
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


    private void EjectEmptyShells()
    {

        if ((shotgunHinge.angle < 30f && shotgunHinge.angle > 15f ) && isTopLoaded == false)
        {
            Debug.Log("Ready to eject magazine");
            topSocket.SetActive(false);
            
        }
        if ((shotgunHinge.angle < 30f && shotgunHinge.angle > 15f) && isBotLoaded == false)
        {
            Debug.Log("Ready to eject magazine");
            botSocket.SetActive(false);
            
        }
        else
        {
            Debug.Log("Not ready for eject");
            topSocket.SetActive(true);
            botSocket.SetActive(true);
        }
    }
    

    


}
