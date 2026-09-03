using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactStarUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CscrollToPos_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArtifactStarUIPanel _003C_003E4__this;

		public List<ArtifactAttrItem> list;

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
		public _003CscrollToPos_003Ed__41(int _003C_003E1__state)
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

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public GameObject[] RatityObj;

	public DxxText Text_Name;

	public ArtifactStarShowItem starItem;

	public HeroPropInfoCtrl ATKItem;

	private int LastATKValue;

	public HeroPropInfoCtrl HPItem;

	private int LastHPValue;

	public ButtonCtrl Button_View;

	public GameObject ViewIcon1;

	public GameObject ViewIcon2;

	public ButtonCtrl Button_Preview;

	public DxxText Text_Preview;

	public DxxText Text_AttrTitle;

	public GameObject cpAttrItem;

	public RectTransform Content;

	public ScrollRect scrollRect;

	public DxxText Text_ProgressTitle;

	public Slider slider;

	public DxxText Text_Progress;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public GameObject RedPoint;

	public DxxText Text_Tips;

	public ArtifactMatItem[] matItems;

	private bool isMatEnough;

	public ArtifactModelShow modelShow;

	public GameObject LevelUpAni;

	public GameObject StarUpAni;

	private LocalSave.ArtifactOne artiOne;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void initUI()
	{
	}

	private void freshStarUp()
	{
	}

	private void initTopInfo()
	{
	}

	private void freshTopInfo()
	{
	}

	private void initSkillList()
	{
	}

	[IteratorStateMachine(typeof(_003CscrollToPos_003Ed__41))]
	private IEnumerator scrollToPos(List<ArtifactAttrItem> list)
	{
		return null;
	}

	private void freshSkillList()
	{
	}

	private void freshProgress(bool ani = false)
	{
	}

	private void freshMats()
	{
	}

	private void freshButtons()
	{
	}

	private void freshLeftButton()
	{
	}

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}

	private void onButtonAdd()
	{
	}

	private void onButtonStar()
	{
	}

	private void onButtonPreview()
	{
	}

	private void onButtonView()
	{
	}
}
