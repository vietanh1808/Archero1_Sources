using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyFlyCtrl
{
	public class CurrencyUseStruct
	{
		public CurrencyType type;

		public long count;

		public Vector3 endpos;

		public Action callback;
	}

	public class CurrencyGetStruct
	{
		public CurrencyType type;

		public long count;

		public Vector3 startpos;
	}

	public class CurrencyUseAction : ActionBasic.ActionUIBase
	{
		public GameObject gameobject;

		public Vector3 endpos;

		private Image image;

		private Vector3 startpos;

		private Vector3 startoffsetpos;

		private float offsets;

		private float offsettime;

		private float flytime;

		private float alphastarttime;

		private float starttime;

		private AnimationCurve curve;

		private bool bMoveOffset;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void UpdateAlpha()
		{
		}

		private void UpdateOffset()
		{
		}

		private void UpdateFly()
		{
		}
	}

	private class CurrencyFlyData
	{
		public string path;

		public float range;
	}

	private ActionBasic action;

	private static Dictionary<CurrencyType, CurrencyFlyData> mList;

	private static Dictionary<int, CurrencyFlyData> mList2;

	private static bool isInit;

	private static Dictionary<int, CurrencyFlyData> mList2Show => null;

	public void UseAction(string typename, Transform parent, Vector3 startpos, Vector3 endpos, long count, Action callback)
	{
	}

	private GameObject GetGameobject(string name, Transform parent, Vector3 startpos)
	{
		return null;
	}

	public void DeInit()
	{
	}

	public static void UseCurrency(CurrencyType type, long count, Vector3 endpos, Action callback)
	{
	}

	public static void GetCurrency(CurrencyType type, int count, Vector3 startpos)
	{
	}

	public static void PlayKeyUse(long count, Vector3 startpos, Vector3 endpos, Action onFinish)
	{
	}

	private static Dictionary<int, CurrencyFlyData> GetPropDic()
	{
		return null;
	}

	private static Transform GetObject(string path, Vector3 startpos, Transform parent)
	{
		return null;
	}

	public static void PlayGet(CurrencyType type, long allcount, Action<long> OnOverOne = null, Action onFinish = null, bool mask = true)
	{
	}

	public static void PlayGet(int propID, long allcount, Action<long> OnOverOne = null, Action onFinish = null, bool mask = true)
	{
	}

	public static void PlayGetWithDefaultPos(CurrencyType type, long allcount, Action<long> OnOverOne = null, Action onFinish = null, bool mask = true)
	{
	}

	public static void PlayGet(CurrencyType type, long allcount, Vector3 startpos, Action<long> OnOverOne = null, Action onFinish = null, bool mask = true)
	{
	}

	public static void PlayGet(int propID, long allcount, Vector3 startpos, Action<long> OnOverOne = null, Action onFinish = null, bool mask = true)
	{
	}

	public static void PlayGet(CurrencyType type, long allcount, Vector3 startpos, Vector3 endpos, Action<long> OnOverOne, Action onFinish, bool mask, float speedScale = 1f)
	{
	}

	public static void PlayGet(int propID, long allcount, Vector3 startpos, Vector3 endpos, Action<long> OnOverOne, Action onFinish, bool mask)
	{
	}

	public static void PlayFlyAnimation(CurrencyType type, long allcount, Vector3 startpos, Vector3 endpos, Action<long> OnOverOne, Action onFinish, bool mask, float speedScale = 1f)
	{
	}

	public static void PlayFlyAnimation(int propID, long allcount, Vector3 startpos, Vector3 endpos, Action<long> OnOverOne, Action onFinish, bool mask)
	{
	}
}
