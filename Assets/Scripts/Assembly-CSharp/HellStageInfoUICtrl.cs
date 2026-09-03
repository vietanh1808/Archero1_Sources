using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using UnityEngine;

public class HellStageInfoUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CSetMaxData_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HellStageInfoUICtrl _003C_003E4__this;

		private List<HellLevelData> _003CbgData_003E5__2;

		private int _003Ci_003E5__3;

		private HellLevelData _003Cdata_003E5__4;

		private List<HellSystemData>.Enumerator _003C_003E7__wrap4;

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
		public _003CSetMaxData_003Ed__77(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GameObject Go_Tabs;

	public Transform[] loaders;

	public GameObject[] go_BossMark;

	public ButtonCtrl Btn_Close;

	public ButtonCtrl Btn_SunTip;

	public DxxText txt_StageTitle;

	public DxxText txt_stageInfoTitle;

	public DxxText txt_MonsterInfoTitle;

	public DxxText txt_MonsterTitle;

	public DxxText txt_Recommend;

	public DxxText txt_TabPlay;

	public DxxText txt_TabSweep;

	public GameObject _IntroNodes;

	public HellStageBuffItem item;

	public Transform itemParent;

	public Transform monsterParent;

	public GameObject go_Tips;

	public GameObject go_SubTips;

	public DxxText txt_TipsInfo;

	public DxxText txt_TipsTitle;

	public GameObject go_Split;

	public ButtonCtrl btn_Play;

	public ButtonCtrl btn_Sweep;

	public ButtonCtrl btn_TabPlay;

	public ButtonCtrl btn_TabSweep;

	public ButtonCtrl btn_Info;

	public DxxText txt_Play;

	public DxxText txt_Sweep;

	public DxxText txt_HarvestTitle;

	public GameObject ButtonSweepMask;

	public GameObject ButtonStartMask;

	public RedNodeCtrl RedCtrl;

	public DxxText Text_num;

	public DxxText Text_time;

	public RectTransform rect_Bg;

	public GameObject go_LevelInfo;

	public GameObject go_Harvest;

	public GameObject[] go_Selected;

	public BattlePass_ChestPropOne propTemplate;

	public ScrollRectBase mScrollRect;

	public GameObject Go_DiamondCard;

	public DxxText Text_DiamondCard;

	public GameObject go_InfoPanel;

	public DxxText txt_InfoContent;

	public DxxText txt_tipSubContent;

	public DxxText txt_InfoTitle;

	public ButtonCtrl btn_InfoClose;

	public DxxText _IntroTxts;

	public GameObject HeroDropObj;

	public RectTransform HeroContent;

	public GameObject cpHeroItem;

	public SweepHeroPopItem heroPopItem;

	[Header("仅供测试")]
	public float BlessShow;

	public float GuardShow;

	public bool IsOpenTest;

	private const int LineCount = 5;

	private const float WidthOne = 142f;

	private const float HeightOne = 142f;

	private SequencePool mSeqPool;

	private int currentStage;

	private LocalUnityObjctPool pool;

	private int crtTab;

	private bool _isUIBusy;

	private bool isGetData;

	private int countIndex;

	private List<HellLevelData> crtData => null;

	private HellLevelInfoDataMgr hMgr => null;

	private bool isUnlockSweep => false;

	private bool isUIBusy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void SetData()
	{
	}

	[IteratorStateMachine(typeof(_003CSetMaxData_003Ed__77))]
	public IEnumerator SetMaxData()
	{
		return null;
	}

	public void InitUI()
	{
	}

	public void InitSweep()
	{
	}

	public void InItBuff()
	{
	}

	public void OnItemClick(HellLevelData hOne, Vector3 pos)
	{
	}

	private void LoadMonster(int monsterID, Transform parent)
	{
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	private void OnClickSweep()
	{
	}

	private void updateSweepCnt()
	{
	}

	private void showResult()
	{
	}

	private string ArrayToString(uint[] array)
	{
		return null;
	}

	private void OnClickPlay()
	{
	}

	private void playGame()
	{
	}

	private void OnClickInfoBtn()
	{
	}

	private void Update()
	{
	}

	public void SetTab(int tab)
	{
	}

	public void Esc()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}

	public void OnCloseTipsClick()
	{
	}

	private void onButtonHeroItem(HeroTrainLevelDropData htData, Vector3 position)
	{
	}
}
