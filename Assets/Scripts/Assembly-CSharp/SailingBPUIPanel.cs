using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingBPUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CCheck_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingBPUIPanel _003C_003E4__this;

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
		public _003CCheck_003Ed__50(int _003C_003E1__state)
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

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public DxxText Text_Level;

	public DxxText Text_Progress;

	public Slider slider;

	public ButtonCtrl Button_Normal;

	public ButtonCtrl Button_Premium;

	public DxxText Text_Free;

	public DxxFitContentText Text_Normal;

	public DxxFitContentText Text_Premium;

	public Image middleBg;

	public RectTransform rectBox;

	public Transform stageParent;

	public SailingBpStageItem stageItem;

	[Header("最终宝箱")]
	public Image bottomBoxBg;

	public DxxText txtExtraTitle;

	public DxxText txtExtraContent;

	public DxxText txtExtraCount;

	public DxxText txtExtraGet;

	public BattlePass_BigPropOne extraProp;

	public BattlePassChestInformation chestInfo;

	private LocalUnityObjctPool _pool;

	private List<SailingBpStageItem> stageList;

	private int currentLevel;

	private long showTimex;

	private long crtStageEndTime;

	private long crtStageStartTime;

	private int _crtStage;

	private bool _isStageEnd;

	private bool _isFirstStage;

	public UITableView tableView;

	[HideInInspector]
	public List<SailingBPData> dataList;

	public SailingBPItemCell cellItem;

	private RectTransform rectBuyItem;

	private SailingBpExtraData _extraData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public void InitStageItem()
	{
	}

	public void OnBtnStageItemClicked(int stage)
	{
	}

	public void RefreshStateByStage()
	{
	}

	public void RefreshExtraBox()
	{
	}

	public void OnClickedExtraBox(PropOneBase prop, object obj)
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onButtonOpenNormal()
	{
	}

	private void onButtonOpenPremium()
	{
	}

	public void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	public void RefreshUI()
	{
	}

	private void RefreshLevel()
	{
	}

	[IteratorStateMachine(typeof(_003CCheck_003Ed__50))]
	private IEnumerator Check()
	{
		return null;
	}

	private void freshTime()
	{
	}

	private string GetRomanStage(int stage)
	{
		return null;
	}

	public int checkScorllTo()
	{
		return 0;
	}

	public void initTableView()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}
}
