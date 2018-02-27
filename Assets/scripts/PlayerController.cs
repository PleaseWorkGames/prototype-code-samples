using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public bool active = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public float up(){
		return active && Input.GetAxis("Vertical")>0?Input.GetAxis("Vertical"):0;
	}

	public float down(){
		return active && Input.GetAxis("Vertical")<0?Input.GetAxis("Vertical"):0;
	}

	public float left(){
		return active && Input.GetAxis("Horizontal")<0?Input.GetAxis("Horizontal"):0;
	}

	public float right(){
		return active && Input.GetAxis("Horizontal")>0?Input.GetAxis("Horizontal"):0;
	}

	public bool interact(){
		return active && Input.GetKey(KeyCode.Space);
	}
}
