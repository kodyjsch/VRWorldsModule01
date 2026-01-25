using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollide : MonoBehaviour
{

    private GameObject hitPickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            hitPickUp = other.gameObject;
            Destroy(hitPickUp);
            Destroy(gameObject);
        }
    }
}
