using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Transform player;

	public float fowardForce = 2000f;
	public float sideForce = 500f;
	public float upForce = 0f;
	
	
	
	// Update is called once per frame
	// Fixed update works better with Unity's physics engine than just Update
	void FixedUpdate () {
		//Adds a foce to the rigidbody rb thats not dependent on framerate, thanks to multilying the value by deltaTime
		rb.AddForce(0, 0, fowardForce * Time.deltaTime);

		if (Input.GetKey("d")) {
			rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")) {
			rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("space") && player.position.y >= 0 && player.position.y <= 2 ) {
			rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.Impulse);
		}

		if (rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
