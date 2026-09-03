using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity.Anniversary;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

public class PuzzleUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CTick_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PuzzleUICtrl _003C_003E4__this;

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
		public _003CTick_003Ed__54(int _003C_003E1__state)
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

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private DxxText txtCountdownTab;

	[SerializeField]
	private ButtonCtrl btnInfoTab;

	[SerializeField]
	private ButtonCtrl[] btnJigsaws;

	[SerializeField]
	private RedNodeCtrl[] redNodes;

	[SerializeField]
	private PuzzleChestItem[] chests;

	[SerializeField]
	private DxxImage imgJigsaw;

	[SerializeField]
	private DxxImage[] imgJigsaws;

	[SerializeField]
	private Sprite spNormal;

	[SerializeField]
	private Sprite spCompleted;

	[SerializeField]
	private CanvasGroup cgJigsaw;

	[SerializeField]
	private RectTransform rtContainer;

	[SerializeField]
	private RectTransform rtBgPlates;

	[SerializeField]
	private RectTransform rtJigsaw;

	[SerializeField]
	private PuzzleTaskPop taskPop;

	[SerializeField]
	private InfoPopPanel infoPopPanel;

	[SerializeField]
	private RectTransform titleContent;

	[SerializeField]
	private ButtonCtrl btn_Bg;

	[SerializeField]
	private DxxText TopText;

	[SerializeField]
	private DxxText ProgressText;

	[SerializeField]
	private Slider ProgressSlider;

	[FormerlySerializedAs("GetFinalRewardBtn")]
	[SerializeField]
	private ButtonCtrl SingleRewardBtn;

	[SerializeField]
	private ButtonCtrl ChestRewardBtn;

	[SerializeField]
	private GameObject CheckImage;

	[SerializeField]
	private Animation ChestAnim;

	[SerializeField]
	private Animation SingleAnim;

	[SerializeField]
	private GameObject ChestImg;

	[SerializeField]
	private PropOneEquip PropOne;

	[SerializeField]
	private PropOneEquip PropFinalRewardItem;

	[SerializeField]
	private GameObject FinalRewardParent;

	[SerializeField]
	private ButtonCtrl HideBgBtn;

	private Material mat;

	private Texture2D texMask;

	private static readonly int idMaskTex;

	private Coroutine ticker;

	private bool isCompletePuzzle;

	private static readonly Color deepGray;

	private static DelegateBridge __Hotfix0_get_PuzzleManager;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshJigsaw;

	private static DelegateBridge __Hotfix0_RefreshChests;

	private static DelegateBridge __Hotfix0_RefreshFinalRewardText;

	private static DelegateBridge __Hotfix0_RefreshTexMask;

	private static DelegateBridge __Hotfix0_RefreshTexts;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnClickInfoTab;

	private static DelegateBridge __Hotfix0_ShowTaskPop;

	private static DelegateBridge __Hotfix0_CheckJigsaw;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_RefreshCountdown;

	private static DelegateBridge __Hotfix0_Tick;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnClickSingleReward;

	private static DelegateBridge __Hotfix0_OnClickChestReward;

	private static DelegateBridge __Hotfix0_HideItemTip;

	private static DelegateBridge __Hotfix0_RefreshFinalRewardBtn;

	private static DelegateBridge __Hotfix0_ClickTip;

	private static DelegateBridge __Hotfix0_ClaimSuccess;

	private static DelegateBridge _c__Hotfix0_ctor;

	private PuzzleManager PuzzleManager => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshJigsaw()
	{
	}

	public void RefreshChests()
	{
	}

	private void RefreshFinalRewardText()
	{
	}

	public void RefreshTexMask()
	{
	}

	public void RefreshTexts()
	{
	}

	protected override void OnClose()
	{
	}

	public void OnClickInfoTab()
	{
	}

	public void ShowTaskPop(bool isChest, int index, PuzzleTaskItemData taskData, PuzzleChestItemData chestData)
	{
	}

	public void CheckJigsaw()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void RefreshCountdown()
	{
	}

	[IteratorStateMachine(typeof(_003CTick_003Ed__54))]
	public IEnumerator Tick()
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	private void OnClickSingleReward()
	{
	}

	private void OnClickChestReward()
	{
	}

	private void HideItemTip()
	{
	}

	private void RefreshFinalRewardBtn()
	{
	}

	private void ClickTip()
	{
	}

	public void ClaimSuccess(STRespActivityPuzzle response)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
