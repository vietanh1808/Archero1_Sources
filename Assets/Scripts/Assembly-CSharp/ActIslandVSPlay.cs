using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ActIslandVSPlay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowRatioTips_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActIslandVSPlay _003C_003E4__this;

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
		public _003CShowRatioTips_003Ed__88(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CStartLongPressBtn_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActIslandVSPlay _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CStartLongPressBtn_003Ed__87(int _003C_003E1__state)
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

	public ActIslandVSUIPanel uiPanel;

	public GameObject Mask;

	public Slider sliderHP;

	public DxxText Text_HP;

	public Image[] Image_HPBG;

	public DxxText Text_Damage;

	public ActIslandVSBoxItem boxItem;

	public ButtonCtrl Button_BoxInfo;

	public ActIslandVSBossItem bossItem;

	public Image Image_Dice;

	public GameObject DiceAniObj;

	public GameObject WinObj;

	public DxxText Text_Win;

	public GameObject FailObj;

	public DxxText Text_Fail;

	public GameObject DrawObj;

	public DxxText Text_Draw;

	public DxxText Text_DrawDice;

	public GameObject Light1;

	public GameObject Light2;

	public GameObject Indicator;

	public ButtonCtrl Button_Dice;

	public ButtonCtrl Button_Ratio;

	public DxxText Text_Ratio;

	public DxxText Text_DiceNum;

	public DxxText Text_Auto;

	public GameObject DiceGreenBG;

	public GameObject DiceMask;

	public GameObject RatioPurpleBG;

	public CanvasGroup tipsCanvas;

	public DxxText tipsDesc;

	public DxxText tipsRatioTex;

	public Image tipsRatioImg;

	private Coroutine ShowTipsCor;

	public RectTransform outWheel;

	public RectTransform inWheel;

	public ActIslandVSPropItem[] propItems;

	public ActIslandVSDiceItem[] diceItems;

	public GameObject Wheel_Shine;

	public Image Image_WheelShine;

	public AnimationCurve CurveRotate;

	public Image[] Rule_BossDice;

	public GameObject[] Rule_BossRect;

	public Image[] Rule_MeDice;

	public GameObject[] Rule_MeRect;

	public Image Rule_MeHead;

	public ActIslandVSAniLayer aniLayer;

	private int lighter;

	private bool isInit;

	private int ratioIndex;

	private List<int> ratioList;

	private bool needSwitchWheel;

	private bool isWheeling;

	private Tween tweenAni;

	private Coroutine LongPressCor;

	private bool isAutoing;

	private float LongPressDra;

	private void Awake()
	{
	}

	private void init()
	{
	}

	public void initUI()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void onLanguaged()
	{
	}

	public void onClosed()
	{
	}

	private void initLight()
	{
	}

	public void switchLight()
	{
	}

	private void initBox()
	{
	}

	private void onButtonDice()
	{
	}

	private void requestDice()
	{
	}

	private void doDice()
	{
	}

	private void onButtonRatio()
	{
	}

	private void onButtonBoxInfo()
	{
	}

	private int GetRorateAngleOffest(int current, int next, bool outin)
	{
		return 0;
	}

	private void freshDiceNum()
	{
	}

	private void initRatio()
	{
	}

	private int GetRatioValue()
	{
		return 0;
	}

	private void freshRatio()
	{
	}

	private void freshDrawDice()
	{
	}

	private void initWheelAngel(DiceBattleData dbdata)
	{
	}

	private void initWheel(DiceBattleData dbdata)
	{
	}

	private void initBossHP(DiceBattleData dbdata, bool init, bool sth)
	{
	}

	private void resetInitState()
	{
	}

	private void initRightRule(DiceBattleData dbdata)
	{
	}

	public void onButtonRightRule()
	{
	}

	public void onButtonMask()
	{
	}

	private void setAutoState(bool state)
	{
	}

	private void onButtonDownDice()
	{
	}

	private void onButtonUpDice()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLongPressBtn_003Ed__87))]
	private IEnumerator StartLongPressBtn()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowRatioTips_003Ed__88))]
	private IEnumerator ShowRatioTips()
	{
		return null;
	}
}
