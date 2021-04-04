using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	Vector3 velocity;
	
	void Update () {
		velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * 10;
	}

	void FixedUpdate() {
		GetComponent<Rigidbody>().MovePosition (GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
	}
}
