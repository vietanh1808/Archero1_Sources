using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HeroAssistAttrItem : MonoBehaviour
{
	public class ShowData
	{
		public string effect;

		public int needLevel;

		public int curLevel;

		public bool assist;
	}

	[CompilerGenerated]
	private sealed class _003CPlayUpgradeAnim_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public HeroAssistAttrItem _003C_003E4__this;

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
		public _003CPlayUpgradeAnim_003Ed__17(int _003C_003E1__state)
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

	public RectTransform RTF;

	public Image Image_BG;

	public DxxText attrText;

	public GameObject allObj;

	public DxxText allText;

	private static readonly Color bgcolor;

	private static Color textcolor;

	private static Color imagecolor;

	private static Color whiteColor;

	public GameObject Locker;

	public GameObject Unlocker;

	public DxxText Text_NeedLevel;

	public Animator UpgradeAnim;

	private ShowData data;

	public void init(ShowData data)
	{
	}

	public void CheckPlayLevelUp()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayUpgradeAnim_003Ed__17))]
	private IEnumerator PlayUpgradeAnim(float waitTime)
	{
		return null;
	}
}
