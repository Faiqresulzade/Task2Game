using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        RaycastHit raycastHit;
        if(Physics.Raycast(transform.position, transform.forward, out raycastHit,100f))
        {
            Debug.Log(raycastHit.transform.gameObject.name);
        }
        Mathf.Clamp(transform.position.x, -5, 5);
    }
}
