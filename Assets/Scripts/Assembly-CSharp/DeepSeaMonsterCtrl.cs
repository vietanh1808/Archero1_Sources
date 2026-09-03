using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class DeepSeaMonsterCtrl : MediatorCtrlBase
{
	public class TimeLineItemShoot : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CShootInternal_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineItemShoot _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CShootInternal_003Ed__4(int _003C_003E1__state)
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

		private DeepSeaMonsterCtrl m_Ctrl;

		private List<SailingMonsterMCannonDamageData> m_DamageDatas;

		private Action<SailingMonsterMCannonDamageData> m_ShootDo;

		public TimeLineItemShoot(DeepSeaMonsterCtrl ctrl, List<SailingMonsterMCannonDamageData> damageDatas, Action<SailingMonsterMCannonDamageData> shootDo)
		{
		}

		[IteratorStateMachine(typeof(_003CShootInternal_003Ed__4))]
		private IEnumerator ShootInternal()
		{
			return null;
		}
	}

	public class TabBtns
	{
		public class TabBtn
		{
			private int m_index;

			public ButtonCtrl button;

			public GameObject focusObj;

			public RedNodeCtrl redObj;

			public Text nameText;

			private bool m_IsFocus;

			private Action<int> callBack;

			public TabBtn(int index, Transform go, Action<int> onClick)
			{
			}

			public void ClickDO()
			{
			}

			public void SetFocus(bool isFocus)
			{
			}

			public void SetRed(bool isShow)
			{
			}

			public void SetName(string name)
			{
			}

			public bool IsFocus()
			{
				return false;
			}

			public int GetIndex()
			{
				return 0;
			}
		}

		private TabBtn[] m_btns;

		public TabBtns(Transform tabBtnParent, Action<int> onClick)
		{
		}

		public void RefreshRed(Func<int, bool> isShowRed)
		{
		}

		public void ClickTab(int index)
		{
		}

		public void Close()
		{
		}

		public void OnLanguageChange(Func<int, string> getName)
		{
		}

		public int GetFocusIndex()
		{
			return 0;
		}
	}

	public DxxText titleTex;

	public DxxText timeTex;

	public DxxText nameTex;

	public DxxText playBtnTex;

	public DxxText shootBtnTex;

	public DxxText playNumTex;

	public DxxText LimitTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl playBtn;

	public ButtonCtrl shootBtn;

	public DeepSeaMonsterBuffItem copyBuffItem;

	public DeepSeaMonsterBuffItem BPItem;

	public ImprintTips tips;

	public SailingRankShowItem sailingRank;

	public DSMBloodPart bloodPart;

	public Image modelImg;

	public Transform buffParent;

	public DSMMuzzle muzzle;

	public DSMShells shellsCopyOne;

	public Transform tabBtnParent;

	private TabBtns tabBtns;

	public DSMDeBuffSlider dSMDeBuffSlider;

	public ButtonCtrl underseaRuinBtn;

	public RedNodeCtrl underseaRuinCtrl;

	public DxxText Text_UnderseaRuin;

	public GameObject rampageEffect;

	[Header("路径点数")]
	public int pathPointCount;

	[Header("炮弹飞行时间")]
	public float shootTime;

	[Header("炮弹偏移范围")]
	public Vector2 offsetRange;

	[Header("炮弹准备时间")]
	public float preTime;

	[Header("炮弹发射间隔")]
	public float shellsIntervalTime;

	private List<DeepSeaMonsterBuffItem> items;

	private DeepSeaMonsterManager.Stage mCurSage;

	private TimeLineContainer timeLine;

	private List<DSMShells> shellsPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void StartRewardAni(int[] arg1, List<Drop_DropModel.DropData> list)
	{
	}

	private void OnDeepSeaMonsterBossRewardCallBack(bool obj)
	{
	}

	private void OnDeepSeaMonsterInfoCallBack(bool obj)
	{
	}

	private void RefreshUI(DeepSeaMonsterManager.Stage stage, bool isFresh)
	{
	}

	protected override void OnClose()
	{
	}

	private void RefreshTabRed()
	{
	}

	private void RefreshBuff()
	{
	}

	private void RefreshConsume()
	{
	}

	private void ClickClose()
	{
	}

	public void OnShoot(List<SailingMonsterMCannonDamageData> damageDatas, List<Drop_DropModel.DropData> reward)
	{
	}

	private void ClickInfo()
	{
	}

	private void onButtonUnderseaRuin()
	{
	}

	private void ClickPlay()
	{
	}

	private void ClickShoot()
	{
	}

	private void freshTime()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void Update()
	{
	}

	private DSMShells GetShells()
	{
		return null;
	}

	private void OnShellsRecyle(DSMShells shell)
	{
	}

	private void StopShoot()
	{
	}

	private void ShootInternal(List<SailingMonsterMCannonDamageData> damageDatas, List<Drop_DropModel.DropData> reward)
	{
	}

	private void ShootShells(SailingMonsterMCannonDamageData damageData)
	{
	}

	private void ClickTab(int index)
	{
	}

	private string SetTabName(int index)
	{
		return null;
	}

	private bool IsTabRed(int index)
	{
		return false;
	}
}
