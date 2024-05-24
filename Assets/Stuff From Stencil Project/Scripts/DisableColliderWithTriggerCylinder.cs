using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//URL PixTrick Video : https://www.youtube.com/watch?v=y-SEiDTbszk
//Repo Github : https://github.com/PixTrick/StencilBufferTutorial

public class DisableColliderWithTriggerCylinder : MonoBehaviour
{
    [SerializeField] private Collider targetCollider;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //targetCollider.enabled = false;
            other.GetComponent<Collider>().isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetCollider.enabled = true;
        }
    }
}
