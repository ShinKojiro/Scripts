using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);

        //CancelInvoke("SpawnObject");
    }

    // Update is called once per frame
    void Update()
    {
        /*float x = Random.Range(-20.0f, 20.0f);
        float z = Random.Range(-20.0f, 20.0f);
        Instantiate(target, new Vector3(x, 10, z), Quaternion.identity);*/
    }

    void SpawnObject()
    {
        float x = Random.Range(-20.0f, 20.0f);
        float z = Random.Range(-20.0f, 20.0f);
        Instantiate(target, new Vector3(x, 10, z), Quaternion.identity);
    }    
}
