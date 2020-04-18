using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform cylinderEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, cylinderEnd.position, cylinderEnd.rotation) as Rigidbody;
            projectileInstance.AddForce(cylinderEnd.up * 350f);
        }
    }
}
