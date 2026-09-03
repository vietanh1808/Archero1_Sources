using System;
using UnityEngine;

public class LoadSyncCtrl : MonoBehaviour
{
	public static LoadSyncCtrl Load<T>(string path, Action<T> complete) where T : UnityEngine.Object
	{
		return null;
	}

	public void DeInit()
	{
	}
}
