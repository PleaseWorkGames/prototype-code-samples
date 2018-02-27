using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuItem : MonoBehaviour {

	public string text = "Hello World!";

	private RectTransform container;

	private Text textComponent;

	// Use this for initialization
	void Start () {

		container = this.GetComponent<RectTransform>();

		textComponent = this.GetComponent<Text>();

		if(textComponent == null){
			textComponent = getDefaultTextComponent();
		}

		text = textComponent.text;

		
	}

	private Text getDefaultTextComponent(){
		Text result = gameObject.AddComponent(typeof(Text)) as Text;

		result.text = this.text;

		result.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
		result.alignment = TextAnchor.MiddleCenter;

		return result;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Vector2 point = Input.mousePosition;

			if(RectTransformUtility.RectangleContainsScreenPoint(container,point)){
				menuAction();
			}
		}
		
	}

	public virtual void menuAction(){
		Debug.Log(text);
	}
}
