using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private float spawnSpeed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            GameObject spawnedBall = Instantiate(prefab, transform.position, transform.rotation);
            Rigidbody spawnedBallRb = spawnedBall.GetComponent<Rigidbody>();
            spawnedBallRb.velocity = transform.forward * spawnSpeed;
        }
    }

    public void SpawnBallWithHand()
    {
        GameObject spawnedBall = Instantiate(prefab, transform.position, transform.rotation);
        Rigidbody spawnedBallRb = spawnedBall.GetComponent<Rigidbody>();
        spawnedBallRb.velocity = transform.forward * spawnSpeed;
    }
}
