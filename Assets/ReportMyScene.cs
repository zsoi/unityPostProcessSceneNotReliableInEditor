using UnityEngine;

public class ReportMyScene : MonoBehaviour
{
	void Start()
	{
		Debug.LogErrorFormat("Hey! I'm {0} and I am in scene {1}", name, gameObject.scene.name);
	}
}
