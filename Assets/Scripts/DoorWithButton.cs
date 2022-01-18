using UnityEngine;

public class DoorWithButton : MonoBehaviour
{    
    public Animator Button;
    public GameObject Door;
    public Transform DoorTarget;
    private float speed = 0.2f;
    //private Vector3 Target = new Vector3(0, 1.6f, -1f);    
    private bool flag = false;
    
    void Update()
    {
        if (flag == true)
        {
            OpenDoor();
        }
    }
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("Button presset");
            Button.SetTrigger("ButtonTrigger");
            flag = true;
        }
    }
    
    private void OpenDoor()
    {
        Door.transform.position = Vector3.MoveTowards(Door.transform.position, DoorTarget.transform.position, Time.deltaTime * speed);
    }
}
