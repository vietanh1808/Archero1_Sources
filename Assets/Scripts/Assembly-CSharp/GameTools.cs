using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Net;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public static class GameTools
{
	[CompilerGenerated]
	private sealed class _003CPlay_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool useTimeScale;

		public Animation animation;

		public string clipName;

		public Action onComplete;

		private AnimationState _003C_currState_003E5__2;

		private bool _003CisPlaying_003E5__3;

		private float _003C_progressTime_003E5__4;

		private float _003C_timeAtLastFrame_003E5__5;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPlay_003Ed__50(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static void SortParticle(this Transform transform)
	{
	}

	public static void MakeParticleAsTop(this Transform transform)
	{
	}

	public static void RandomSort<T>(this List<T> list)
	{
	}

	public static void DestroyChildren(this Transform t)
	{
	}

	public static void HideAllChild(this Transform t)
	{
	}

	public static void SetChildrenVisible(this Transform t, bool visible)
	{
	}

	public static void SortPsRenderByZOrder(this Transform transform)
	{
	}

	public static void SetPsRenderAsTop(this Transform t)
	{
	}

	public static void StandardTransform(this Transform t)
	{
	}

	public static List<T> GetComponentsInChildrens<T>(this GameObject t) where T : Component
	{
		return null;
	}

	public static void SetParentNormal(this GameObject child, Transform parent)
	{
	}

	public static void SetParentNormal(this MonoBehaviour child, Transform parent)
	{
	}

	public static void SetParentNormal(this Transform child, GameObject parent)
	{
	}

	public static void SetParentNormal(this GameObject child, GameObject parent)
	{
	}

	public static void SetParentNormal(this Transform child, Transform parent)
	{
	}

	private static void SetParentNormalInternal(Transform child, Transform parent)
	{
	}

	public static Transform GetFirstParent(this Transform t)
	{
		return null;
	}

	public static void SetLeft(this Transform t)
	{
	}

	public static void SetLeft(this GameObject o)
	{
	}

	public static void SetLeft(this RectTransform t)
	{
	}

	public static void SetLeftInternal(RectTransform t)
	{
	}

	public static void SetLeftTop(this Transform t)
	{
	}

	public static void SetLeftTop(this GameObject o)
	{
	}

	public static void SetLeftTop(this RectTransform t)
	{
	}

	public static void SetLeftTopInternal(RectTransform t)
	{
	}

	public static void SetTop(this RectTransform t)
	{
	}

	public static void SetTop(this Transform t)
	{
	}

	public static void SetMiddle(this Transform t)
	{
	}

	public static void SetMiddle(this RectTransform t)
	{
	}

	public static void SetMiddleInternal(RectTransform t)
	{
	}

	public static void SetTopInternal(RectTransform t)
	{
	}

	public static bool TryParse(this string str, out float value)
	{
		value = default;
		return false;
	}

	public static float ParseFloat(this string str)
	{
		return 0f;
	}

	public static int ParseInt(this string str)
	{
		return 0;
	}

	public static long ParseLong(this string str)
	{
		return 0L;
	}

	public static ulong ParseUlong(this string str)
	{
		return 0uL;
	}

	public static void SetParticalScale(this GameObject obj, Vector3 scale)
	{
	}

	public static void SetParticalScale(this GameObject obj, float scale)
	{
	}

	public static void SetParticalScale(this GameObject obj, float scalex, float scaley, float scalez)
	{
	}

	public static void SetParticalDuration(this GameObject obj, float duration)
	{
	}

	public static void ClearParticle(this GameObject obj, bool includeInactive = false)
	{
	}

	public static void ClearTrailRenderer(this GameObject obj)
	{
	}

	public static void StopParticles(this GameObject obj, bool includeInactive = false)
	{
	}

	public static void PlayParticles(this GameObject obj, bool includeInactive = false)
	{
	}

	public static string ColorToHex(this Color32 color)
	{
		return null;
	}

	public static string ColorToHex(this Color color)
	{
		return null;
	}

	public static Color HexToColor(this string hex)
	{
		return default;
	}

	public static string IntToRoman(this int num)
	{
		return null;
	}

	public static float GetTextWidth(this Text text)
	{
		return 0f;
	}

	public static float GetTextHeight(this Text text)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CPlay_003Ed__50))]
	public static IEnumerator Play(this Animation animation, string clipName, bool useTimeScale, Action onComplete)
	{
		return null;
	}

	public static void ClearRaycastResults(this GraphicRaycaster gRaycaster)
	{
	}

	public static void ChangeSortLayerId(this GameObject gameObject, int id)
	{
	}

	public static void ChangeParticleOrderInLayer(this GameObject gameObject, int order)
	{
	}

	public static void PlayParticles(this GameObject gameObject)
	{
	}

	public static string GetPropName(this Goods_goods.GoodData prop)
	{
		return null;
	}

	public static string GetPropString(this Goods_goods.GoodData prop)
	{
		return null;
	}

	public static string GetPropValueString(this Goods_goods.GoodData prop)
	{
		return null;
	}

	public static bool IsVisibleInCamera(this EntityBase entity, out Vector3 viewPos)
	{
		viewPos = default;
		return false;
	}

	public static void Shuffle<T>(this T list, int count = 0) where T : IList
	{
	}

	public static float HightOffset()
	{
		return 0f;
	}

	public static T[] ForEach<T>(this T[] array, Action<T, int> action)
	{
		return null;
	}

	public static T[] ArrayWhere<T>(this T[] array, Func<T, bool> func)
	{
		return null;
	}

	public static T[] Sort<T>(this T[] array, Comparison<T> comparison)
	{
		return null;
	}

	public static T[] Add<T>(this T[] array1, T[] array2)
	{
		return null;
	}

	public static T Find<T>(this T[] array, Func<T, bool> func)
	{
		return default;
	}

	public static T2[] ArraySelect<T1, T2>(this T1[] array, Func<T1, T2> func)
	{
		return null;
	}

	public static RectTransform rectTransform(this MonoBehaviour mono)
	{
		return null;
	}

	public static void Send<T1, T2>(this T1 packet, Action<bool, T2, int> callback, SendType sendtype = SendType.eUDP) where T1 : CProtocolBase where T2 : IProtocol
	{
	}

	public static NetBox NetSend<T1>(this T1 packet, SendType sendtype) where T1 : CProtocolBase
	{
		return null;
	}

	public static void FitText(this Text text, float minFontSize, float maxFontSize, float stepSize = 1f)
	{
	}

	public static void SetMaterialSelected(this Image img, bool selected, Color selectColor, bool isInMask)
	{
	}

	public static void AddShipAni(this GameObject ship)
	{
	}
}
