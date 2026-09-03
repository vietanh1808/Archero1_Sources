using System;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeLevelCtrl : MonoBehaviour
{
	public RectTransform child;

	public GameObject copyitems;

	public GameObject challengeone;

	private const float width = 220f;

	private Vector2 startpos;

	private int middleid;

	private int movecount;

	private LocalUnityObjctPool mPool;

	private Dictionary<int, MainChallengeOneCtrl> list;

	private int maxcount;

	private void Awake()
	{
	}

	public void Init(int id)
	{
	}

	private MainChallengeOneCtrl get_one()
	{
		return null;
	}

	public void GoNext(Action finish)
	{
	}
}
