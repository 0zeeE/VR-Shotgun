using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BotLoad : MonoBehaviour
{
    [SerializeField] private GameObject ShotgunBot;

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
            ShotgunBot.GetComponent<Shotgun>().isBotLoaded = true;
        }
    }
}
