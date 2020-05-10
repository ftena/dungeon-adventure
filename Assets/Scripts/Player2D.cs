using UnityEngine;
using System.Collections;

public class Player2D : MonoBehaviour {
	Vector2 velocity;	

	void Update () {
		velocity = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical")).normalized * 10;
	}

	void FixedUpdate() {
		GetComponent<Rigidbody2D>().MovePosition (GetComponent<Rigidbody2D>().position + velocity * Time.fixedDeltaTime);
	}

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp"))
        {
            //... then set the other object we just collided with to inactive.
            other.gameObject.SetActive(false);

            //Add one to the current value of our count variable.
            // count++;

            //Update the currently displayed count by calling the SetCountText function.
            // SetCountText();
        }

		Debug.Log (other.gameObject.name);
    }

	void OnCollisionEnter (Collision col)
	{
		Debug.Log (col.gameObject.name);
	}

	void OnCollisionStay (Collision col)
	{
		Debug.Log (col.gameObject.name);
	}
		
}
