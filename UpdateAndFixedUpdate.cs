using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        // called every physics step
        // fixedupdate intervals are consistent
        // used for regular updates suck as:
        // adjusting physics (ridgidbody) objects

        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update tune :" + Time.deltaTime);
    }
}
