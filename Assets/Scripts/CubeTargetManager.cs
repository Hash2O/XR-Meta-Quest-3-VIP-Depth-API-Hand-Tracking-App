using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTargetManager : MonoBehaviour
{
    private AudioSource m_Source;

    private void Start()
    {
        m_Source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            StartCoroutine(DestroyCubeInASecond());
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator DestroyCubeInASecond()
    {
        m_Source.Play();
        yield return new WaitForSeconds(0.55f);
        Destroy(gameObject);
    }
}
