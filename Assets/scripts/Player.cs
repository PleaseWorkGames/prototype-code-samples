using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public PlayerController controller;

	private Rigidbody2D rb;

	public float moveScale = 1F;
	// Use this for initialization
	void Start () {

		if(controller == null){
			controller = this.gameObject.AddComponent(typeof(PlayerController)) as PlayerController;

			controller.active = true;
		}

		rb = this.gameObject.GetComponent<Rigidbody2D>();

		if( rb == null ){
			rb = initRigidBody();
		}
		
	}

	private Rigidbody2D initRigidBody(){
		Rigidbody2D result = (Rigidbody2D)this.gameObject.AddComponent(typeof(Rigidbody2D));
		result.isKinematic = true;

		return result;
	}

	private void applyMovementInput(){
		rb.MovePosition(new Vector2(rb.position.x + (controller.left() + controller.right()) * moveScale,
									rb.position.y + (controller.up() + controller.down()) * moveScale
									)
						);
	}
	
	// Update is called once per frame
	void Update () {
		applyMovementInput();
	}
}
