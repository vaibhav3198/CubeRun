
using UnityEngine;

public class playerCollision : MonoBehaviour {
	public playerMovement movement;

	void OnCollisionEnter(Collision info)
	{
		if (info.collider.tag == "Obstacle") 
		//Tag is grouping a certain objects
		{
			movement.enabled = false;
			FindObjectOfType<gameManager> ().endGame ();
		}
	}
}
