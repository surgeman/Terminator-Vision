using UnityEngine;
using System.Collections;

public class randomStart : MonoBehaviour {
    private float x;
    public float y;
    private float z;

    private Vector3 newPosition;

    //ArrayList npcArray;

	// Use this for initialization
	//void randomStart ()
    void Awake()
    {
        x = Random.Range(-20f, 20f);
        //y = 15f;
        z = Random.Range(-20f, 20f);

        newPosition = new Vector3(x, y, z);
        transform.position = newPosition;
	}

    void Start()
    {
        /*foreach(GameObject  c in npcArray[])
        {

        }*/
    }

	// Update is called once per frame
	void Update () {
	
	}
}
