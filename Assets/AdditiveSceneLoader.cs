using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoader : MonoBehaviour
{
	public string[] ScenesToLoad;

	IEnumerator Start()
	{
		for (int n = 0; n < ScenesToLoad.Length; n++)
		{
			yield return SceneManager.LoadSceneAsync(ScenesToLoad[n], LoadSceneMode.Additive);
		}
	}
}
