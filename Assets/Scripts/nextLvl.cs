using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLvl : MonoBehaviour {

	public void nextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex +1);
	}
}
