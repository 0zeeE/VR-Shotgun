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
    [SerializeField] private GameObject shotgunShellTop;
    [SerializeField] private GameObject shotgunShellBot;
    




    void Start()
    {
        
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(FireBullet);
        

        
        
       
    }

    // Update is called once per frame
    void Update()
    {



        FindLoadedShells();
        EjectEmptyShells();
    }


    private void FindLoadedShells()
    {
        if(shotgunShellTop == null)
        {
            shotgunShellTop = GameObject.FindGameObjectWithTag("LoadedTopShell");
        }
        if(shotgunShellBot == null)
        {
            shotgunShellBot = GameObject.FindGameObjectWithTag("LoadedBotShell");
        }
        
        

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
        //if ((shotgunHinge.angle > 35f) && isTopLoaded == false && shotgunShellTop.tag =="LoadedTopShell")

        if ((shotgunHinge.angle > 35f) && isTopLoaded == false && shotgunShellTop != null)
        {
            Debug.Log("Ready to eject magazine");
            topSocket.SetActive(false);
            shotgunShellTop.GetComponent<Rigidbody>().AddForce(new Vector3(0, 45f, 0) * 15f * Time.deltaTime);
            Destroy(shotgunShellTop, 2f);
            
        }
        if ((shotgunHinge.angle > 35f ) && isBotLoaded == false && shotgunShellBot != null)
        {
            Debug.Log("Ready to eject magazine");
            botSocket.SetActive(false);
            shotgunShellBot.GetComponent<Rigidbody>().AddForce(new Vector3(45f, 45f, 0) * 15f * Time.deltaTime);
            Destroy(shotgunShellBot, 2f);
        }
        else
        {
           
            Debug.Log("Not ready for eject");
            topSocket.SetActive(true);
            botSocket.SetActive(true);
            

            

        }
    }

    
    

    


}
