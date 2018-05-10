using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour {

	bool end=false;
	public GameObject successUI;

	public void endGame()
	{
		if (end == false) 
		{
			end = true;
			Debug.Log ("Game Over");
			restart ();
		}
	}

	void restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);

	}

	public void success()
	{
		successUI.SetActive (true);
	}
}
