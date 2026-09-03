using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GodWishEraseTool : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CautoAlpah_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GodWishEraseTool _003C_003E4__this;

		private int _003Cx_003E5__2;

		private int _003Cy_003E5__3;

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
		public _003CautoAlpah_003Ed__33(int _003C_003E1__state)
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

	[Header("是否启用")]
	public bool isEnable;

	[Header("毛刷大小")]
	public int brushSize;

	[Header("擦拭比例")]
	public int rate;

	private Action eraserEvent;

	private RawImage uiTex;

	private Texture2D MyTex;

	private int mWidth;

	private int mHeight;

	private int maxColor;

	private int startColor;

	private bool twoPoints;

	private Vector2 startPos;

	private Vector2 endPos;

	private float radius;

	private float distance;

	public GodWishUIPanel wishPanel;

	public int Progress;

	private Camera uiCamera;

	private bool isinit;

	private bool canScratch;

	private void Awake()
	{
	}

	private void init()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private bool isTouchArea(Vector3 pScreenPos)
	{
		return false;
	}

	private void CheckPoint(Vector3 pScreenPos)
	{
	}

	private void editTexAlpha(Vector3 localPos)
	{
	}

	public void getTransparentPercent()
	{
	}

	public void resetTopCover()
	{
	}

	public Vector2[] Beizier(Vector2 start, Vector2 mid, Vector2 end, int segments)
	{
		return null;
	}

	public void recoverAlpha()
	{
	}

	public void beginAuto()
	{
	}

	[IteratorStateMachine(typeof(_003CautoAlpah_003Ed__33))]
	private IEnumerator autoAlpah()
	{
		return null;
	}
}
