using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class DisableColliderAfterInput : MonoBehaviour
{
    
    public InputActionProperty gripAnimationAction;
   [SerializeField] private GameObject boxcollide;
    //private BoxCollider collider;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = gripAnimationAction.action.ReadValue<float>();
        Debug.Log(triggerValue);
        if(triggerValue >= 0.5f)
        {
            boxcollide.SetActive(false);
            
        }
        else
        {
            boxcollide.SetActive(true);
            
        }

    }
}
