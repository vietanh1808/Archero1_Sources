using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class IdentfyGemStoneUICtl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CWaitAniBuy_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IdentfyGemStoneUICtl _003C_003E4__this;

		public IdentfyStoneItemCtl item;

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
		public _003CWaitAniBuy_003Ed__40(int _003C_003E1__state)
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

	public ButtonCtrl closeBtn;

	public ButtonCtrl introductionBtn;

	public IdentfyOpenAnimationCtl openAniCtl;

	[Header("货币")]
	public Text seachNumber;

	public Text dimNumber;

	[Header("NPC")]
	public Text talkText;

	public Text uiName;

	public Text lastTime;

	[Header("货架")]
	public RectTransform center;

	public IdentfyPlanCtl planItem;

	[Header("英雄")]
	public Text heroName;

	public Text effectText;

	public Image heroIcon;

	public ButtonCtrl forgeBtn;

	public Text forgeBtnText;

	public GameObject redNotice;

	[Header("二级界面")]
	public IdentfySeachWindowCtl seachWindow;

	public IdentfySelectUICtl selectWindow;

	public IntroductionWindowCtl introductionWindow;

	public const int planCount = 2;

	private List<IdentfyPlanCtl> planList;

	private List<IdentfyStoneItemCtl> itemList;

	private IdentfyItemListData itemListData;

	private IdentfyUIData uiData;

	private bool isBuying;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	protected void OnAndroid_escape()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnSelectHeroClick()
	{
	}

	private void OnClickIntroduction()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected virtual void RefreshEndTime()
	{
	}

	private void RefItems()
	{
	}

	private void RefCoin()
	{
	}

	private void RefSelectHero()
	{
	}

	public static string GetHeroSkillStr(int pHeroId)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void OnBuyStone(IdentfyStoneItemCtl item)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAniBuy_003Ed__40))]
	private IEnumerator WaitAniBuy(IdentfyStoneItemCtl item)
	{
		return null;
	}

	private void StartBuyLogic(IdentfyStoneItemCtl item)
	{
	}
}
