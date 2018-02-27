using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItem : MonoBehaviour {

	private RectTransform container;

	// Use this for initialization
	void Start () {

		container = this.GetComponent<RectTransform>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Vector2 point = Input.mousePosition;

			if(RectTransformUtility.RectangleContainsScreenPoint(container,point)){
				Debug.Log("Click!");
			}
		}
		
	}
}
