using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class EffectManager
{
	private Dictionary<string, int> mEffectCounts;

	private int perCount;

	private int stCount;

	private const int RemoveTime = 190;

	private const int RemoveMoreTime = 10;

	private float checkTime;

	private Dictionary<string, Queue<GameObject>>.Enumerator iter;

	private Queue<GameObject> iterq;

	private GameObject iterobj;

	private float itertime;

	private string iterkey;

	private int itertimecount;

	private int stCountTemp;

	private Sequence seq_update;

	private Dictionary<string, Queue<GameObject>> mEffectList;

	private Dictionary<string, GameObject> mCloneList;

	private Dictionary<string, float> mTimeList;

	private void KillSequence()
	{
	}

	private void OnUpdate()
	{
	}

	private void RemoveMoreEffects(Queue<GameObject> iterq, int lastcount)
	{
	}

	public GameObject Get(string key)
	{
		return null;
	}

	public void Cache(GameObject o)
	{
	}

	public void Cache(GameObject o, Transform parent)
	{
	}

	public GameObject Get(string key, Transform parent)
	{
		return null;
	}

	public GameObject GetClone(string key)
	{
		return null;
	}

	public void AddToCloneList(string key, GameObject res)
	{
	}

	public bool IsInCloneList(string key)
	{
		return false;
	}

	private float GetLastUseTime(string key)
	{
		return 0f;
	}

	private void SetLastUseTime(string key)
	{
	}

	public void Release()
	{
	}
}
