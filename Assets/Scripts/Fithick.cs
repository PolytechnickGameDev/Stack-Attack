using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fithick : MonoBehaviour {

    public GameObject _object;


    // Use this for initialization
    void Start () {
        _object = (GameObject)this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if(!(_object))
        _object.transform.position -= Vector3.up * Time.deltaTime;
        
	}

    void OnCollisionEnter()
    {
        Debug.Log("Hit Something");  // Передаем сообщение в консоль Unity  
    }
}
