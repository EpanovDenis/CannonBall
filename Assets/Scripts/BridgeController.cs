using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeController : MonoBehaviour
{
    public GameObject HelpPanel;
    public GameObject Lever;
    public GameObject BridgePlane;
    public Transform BridgeTarget;
    public Transform LeverTarget;
    

    private float speed = 50.0f;
    private bool flag = false;
    private bool flagCollision = false;
    private bool flagLever = false;

    // Update is called once per frame
    void Update()
    {
        if (flagCollision == true && Input.GetKeyDown(KeyCode.E))
        {
            flagLever = true;
        }

        if (flagLever == true)
        {
            Lever.transform.Rotate(Time.deltaTime * speed, 0, 0);
            if (Lever.transform.rotation == LeverTarget.transform.rotation)
            {
                flagLever = false;
                flag = true;
            }
        }        

        if (flag == true)
        {
            BridgePlane.transform.Rotate(Time.deltaTime * speed, 0, 0);
            if (BridgePlane.transform.rotation == BridgeTarget.transform.rotation)
            {
                flag = false;
            }            
        }       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Lever.transform.rotation != LeverTarget.transform.rotation)
        {
            HelpPanel.SetActive(true);
            flagCollision = true;
        }        
    }
    private void OnCollisionExit(Collision collision)
    {
        HelpPanel.SetActive(false);
        flagCollision = false;
    }    
}
