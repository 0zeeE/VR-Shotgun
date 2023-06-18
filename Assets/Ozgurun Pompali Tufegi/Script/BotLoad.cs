using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BotLoad : MonoBehaviour
{
    [SerializeField] private GameObject ShotgunBot;
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
        if (other.tag == "ShotgunShell")
        {
            loadSound.Play();
            ShotgunBot.GetComponent<Shotgun>().isBotLoaded = true;
            other.gameObject.tag = "LoadedBotShell";
            Debug.Log(other.gameObject.name + "etiketi " + other.gameObject.tag + "olarak ayarlandi");
            
        }
    }

    
}
