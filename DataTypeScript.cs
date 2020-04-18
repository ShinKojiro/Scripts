using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    private void Start()
    {
        /*Vector3 currentPosition = transform.position;
        currentPosition = new Vector3(0, 2, 0);*/

        Transform tran = transform;
        tran.position = new Vector3(0, 3, 0);
    }
}
