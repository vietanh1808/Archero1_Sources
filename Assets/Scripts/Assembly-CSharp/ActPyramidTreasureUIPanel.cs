using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ActPyramidTreasureUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActPyramidTreasureUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__54(int _003C_003E1__state)
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
	private ButtonCtrl btn_Close;

	[SerializeField]
	private ButtonCtrl btn_Buy;

	[SerializeField]
	private ButtonCtrl btn_Play;

	[SerializeField]
	private ButtonCtrl btn_Info1;

	[SerializeField]
	private ButtonCtrl btn_Info2;

	[SerializeField]
	private ButtonCtrl btn_Info3;

	[SerializeField]
	private ButtonCtrl btn_Task;

	[SerializeField]
	private ButtonCtrl btn_Left;

	[SerializeField]
	private ButtonCtrl btn_Right;

	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_Time;

	[SerializeField]
	private DxxText text_Floor;

	[SerializeField]
	private DxxText text_PropCount;

	[SerializeField]
	private DxxText text_RewardTitle;

	[SerializeField]
	private DxxText text_Play;

	[SerializeField]
	private DxxText text_task;

	[SerializeField]
	private DxxText text_Consume;

	[SerializeField]
	private DxxText text_Start;

	[SerializeField]
	private Toggle toggle_Auto;

	[SerializeField]
	private Text text_AutoPlay;

	[SerializeField]
	private Transform rt_Content;

	[SerializeField]
	private PyramidTreasurePlayUI pyramid_PlayPanel;

	[SerializeField]
	private PyramidRewardUIPanel pyramid_RewardPanel;

	[SerializeField]
	private PyramidNormalRewardUIPanel pyramid_NorRewardPanel;

	[SerializeField]
	private PyramidInfoUIPanel pyramid_InfoPanel;

	[SerializeField]
	private Toggle tg_TestClearCache;

	public PropOneEquip propItem;

	public RectTransform rt_rewardContent;

	public ScrollRectBase scroll_Reward;

	public RedNodeCtrl RedPoint_Task;

	public GameObject go_Playtext;

	public GameObject go_playMask;

	public GameObject go_AllMask;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private bool isLoadedPanel;

	private PyramidTreasurePlayUI playPanel;

	public Transform hammerParent;

	private const float nextPanleY = 640f;

	private LocalUnityObjctPool pool;

	private int crtSpFloorIndex;

	private List<int> spFloors;

	private List<PropOneEquip> showRewards;

	private ActPyramidTreasureMgr ptMgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void LoadPanel()
	{
	}

	public void Refresh()
	{
	}

	public void LoadSpecialRewards(int targetFloor)
	{
	}

	public void RefreshBottom()
	{
	}

	private void LoadNextFloorPanel()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__54))]
	private IEnumerator CountDown()
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshPropCount()
	{
	}

	public void RefreshBtnPlayText()
	{
	}

	public void RefreshBtnTextState()
	{
	}

	public void PlayCircleAni()
	{
	}

	public void RefreshRedPoint()
	{
	}

	public void PlayTurnAroundAni()
	{
	}

	public void OnCloseBtnClick()
	{
	}

	public void OnInfo1BtnClick()
	{
	}

	public void OnInfo2BtnClick()
	{
	}

	public void OnInfo3BtnClick()
	{
	}

	public void OnBtnTaskClick()
	{
	}

	public void OnBtnBuyClick()
	{
	}

	public void OnBtnPlayClick()
	{
	}

	public void RefreshPlayPanel()
	{
	}

	public void OnMaskBtnClick()
	{
	}
}
