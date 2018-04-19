using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour {
    public GameObject Box;
    private Collider BoxColider;
    private int _G = 1;
    // Use this for initialization
    void Start () {
     //   BoxColider = Box.GetComponent<Collider>();


	}
	
	// Update is called once per frame
	void Update () {
        Box.transform.position -= Vector3.up * Time.deltaTime * _G;
    }

    void OnCollisionEnter(Collision BoxColider)
    {
       // BoxColider = Box.GetComponent<Collider>();
        _G = 0;
    }
}
