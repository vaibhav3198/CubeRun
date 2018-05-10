
using UnityEngine;

public class followPlayer : MonoBehaviour {

	public Transform player;//player contains position of player
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		transform.position=player.position+offset;
	}
}
