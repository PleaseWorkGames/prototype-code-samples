using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMenuItem : MenuItem {

	public override void menuAction(){
		Debug.Log("Quitting Application!");
		Application.Quit();
	}

}
