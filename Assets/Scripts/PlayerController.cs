/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float health = 250f;		//	Our ships health

	private Rigidbody2D rgb;		//	A linkt to our beam rigid body

	float xMin;						//	Left boundary of our gamespace
	float xMax;						//	Right boundary of our gamespace


	void Start () {
	}

	
	// Update is called once per frame
	void Update () {

	}

	//	Called everytime our object collides with a trigger collider
	void OnTriggerEnter2D(Collider2D collider) {
		//	We try to identify the object that collided with us as a projectile (laser beam).
	Projectile missile = collider.gameObject.GetComponent<Projectile> ();

		//	If our ship collided with a laser beam, we decrease our ship's health in the amount
		//	of damage set by the projectile.  If the ship's health is zero or less, then we destroy
		//	our ship.
		if (missile) {
			health -= missile.getDamage ();
			missile.Hit ();  	// The missile is destroyed upon collision with our ship.
			if (health <= 0) {
				Die ();
			}
		}
	}

	//	This method destroys the player's ship
	void Die() {
		LevelManager levelManager = GameObject.Find ("LevelManager").GetComponent<LevelManager> ();
		levelManager.LoadLevel ("Lose");
		Destroy (gameObject);
	}
}¨*/