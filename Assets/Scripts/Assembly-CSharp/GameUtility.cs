using System.Collections.Generic;
using UnityEngine;

public static class GameUtility
{
	public static Transform FindDeepChild(GameObject _target, string _childName)
	{
		return null;
	}

	public static T FindDeepChild<T>(GameObject _target, string _childName) where T : Component
	{
		return null;
	}

	public static void AddChildToTarget(Transform target, Transform child)
	{
	}

	public static void ChangeChildLayer(this GameObject o, int layer)
	{
	}

	public static void ChangeChildLayer(this Transform t, int layer)
	{
	}

	public static void ChangeChildLayer(this Transform t, int layer, List<int> filterLayers)
	{
	}

	public static void ChangeChildLayerDifferent(this Transform t, int layer)
	{
	}

	public static void ChangeChildLayerDifferent(this GameObject o, int layer)
	{
	}
}
