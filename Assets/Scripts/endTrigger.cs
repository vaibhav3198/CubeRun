
using UnityEngine;

public class endTrigger : MonoBehaviour {

	void OnTriggerEnter()
	{
		FindObjectOfType<gameManager> ().success ();
	}
}
