using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuItem : MenuItem {

	public override void menuAction(){
		Debug.Log("Starting Game");

		SceneManager.LoadScene("scenes/character-control");

	}
}
