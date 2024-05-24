using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjectOverTime : MonoBehaviour
{
    [SerializeField]
    private float time = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyOnTime(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyOnTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
