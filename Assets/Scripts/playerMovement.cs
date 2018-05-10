
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float fwdForce=2000f;  //variable controlling magnitude of force
	public float sideForce=200f;

	// Update is called once per frame
	void FixedUpdate () //fixed update for physics stuff
	{
		rb.AddForce (0,0,fwdForce*Time.deltaTime);

		if(Input.GetKey("d"))
		{
			rb.AddForce (sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if(Input.GetKey("a"))
		{
			rb.AddForce (-sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if (rb.position.y < -0f) 
		{
			FindObjectOfType<gameManager> ().endGame ();
		}
	}
}
