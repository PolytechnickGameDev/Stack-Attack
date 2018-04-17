using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fithick : MonoBehaviour {

    public GameObject _object;
    public Collider coll = new Collider();

    // Use this for initialization
    void Start () {
        _object = (GameObject)this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
       
        _object.transform.position -= Vector3.up * Time.deltaTime;
        


    }

    void OnTriggerEnter(Collider other)
    {
        _object.transform.position += Vector3.up * Time.deltaTime;
    }
}
