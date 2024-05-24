using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeColliderIsTrigger : MonoBehaviour
{
    [SerializeField] private Collider cylinderCollider;
    [SerializeField] private Collider wallCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SecondPlayer"))
        {
            Debug.Log("Wall Collider Is Trigger");
            cylinderCollider.GetComponent<Collider>().isTrigger = true;
            wallCollider.GetComponent<Collider>().isTrigger = true;
        }
    }

    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SecondPlayer"))
        {
            cylinderCollider.GetComponent<Collider>().isTrigger = false;
            wallCollider.GetComponent<Collider>().isTrigger = false;
        }
    }
    */
}
