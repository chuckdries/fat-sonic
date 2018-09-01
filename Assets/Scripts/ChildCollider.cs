using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("howdy");
		this.transform.parent.GetComponent<PlayerController>().OnChildTriggerEnter(other);		
	}

}
