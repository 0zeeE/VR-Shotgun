using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TopLoad : MonoBehaviour
{
    [SerializeField] private GameObject ShotgunTop;
    [SerializeField] private AudioSource loadSound;
    

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
            loadSound.Play();
            ShotgunTop.GetComponent<Shotgun>().isTopLoaded = true;
            other.gameObject.tag = "LoadedTopShell";  //LoadedShell calisiyor ama inspectorda ayni sekilde gozukuyor.
            Debug.Log(other.gameObject.name + "etiketi " +other.gameObject.tag + "olarak ayarlandi");
            

        }
    }

   
}
