using UnityEditor.Callbacks;
using UnityEngine;

public class ScenePostProcessing
{
	[PostProcessScene]
	static void AddObjectToScene()
	{
		GameObject ngo = new GameObject("SingletonPerScene");
		ngo.AddComponent<ReportMyScene>();
	}
}
