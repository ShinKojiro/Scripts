using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int projectileA;
        public int projectileB;
        public int projectileC;
        public float fuel;

        public Stuff(int prA, int prB, int prC)
        {
            projectileA = prA;
            projectileB = prB;
            projectileC = prC;
        }

        public Stuff(int prA, float fu)
        {
            projectileA = prA;
            fuel = fu;
        }

        //Constructor
        public Stuff()
        {
            projectileA = 1;
            projectileB = 1;
            projectileC = 1;
        }
    }

    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);

    public Stuff myOtherStuff = new Stuff(50, 1.5f);

    public Stuff myImportantStuff = new Stuff();

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(myStuff.projectileA);

        // mutators addded on my own knowledge.
        myImportantStuff.projectileA = 3;
        myImportantStuff.projectileB = 2;
        myImportantStuff.projectileC = 50;
        myImportantStuff.fuel = 200.0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
