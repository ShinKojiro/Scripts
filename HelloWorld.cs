using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private int number;
    [SerializeField] private double numberFloat;
    [SerializeField] private GameObject player;
    [SerializeField] private bool trueOrFalse;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        HelloWorldMethod();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I AM HERE!");
    }

    private void HelloWorldMethod()
    {
        Debug.Log("MY CUSTOM METHOD");
    }
}
