using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class HolyLightUIPanel : MediatorCtrlBase
{
	public class TimeLineItemShoot : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CShootInternal_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CShootInternal_003Ed__6(int _003C_003E1__state)
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

		private Vector3 m_StartPos;

		private Vector3 m_EndPos;

		private HolyLightUIPanel m_Ctrl;

		private Func<Vector3, Vector3, LightPoint> m_ShootDo;

		private List<LightPoint> points;

		public TimeLineItemShoot(HolyLightUIPanel ctrl, Vector3 startPos, Vector3 endPos, Func<Vector3, Vector3, LightPoint> shootDo)
		{
		}

		[IteratorStateMachine(typeof(_003CShootInternal_003Ed__6))]
		private IEnumerator ShootInternal()
		{
			return null;
		}
	}

	public class LightPoint
	{
		public class TimeLineToPoint : TimeLineItem
		{
			[CompilerGenerated]
			private sealed class _003CMove_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public TimeLineToPoint _003C_003E4__this;

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
				public _003CMove_003Ed__5(int _003C_003E1__state)
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

			private Vector3 endPoint;

			private float moveSpeed;

			private Transform self;

			private Vector3 dir;

			public TimeLineToPoint(Transform shell, Vector3 toPoint, float speed)
			{
			}

			[IteratorStateMachine(typeof(_003CMove_003Ed__5))]
			private IEnumerator Move()
			{
				return null;
			}
		}

		private GameObject gameObject;

		private TimeLineContainer timeline;

		public bool isFinish;

		public Action OnFinshDo;

		private Transform transform => null;

		public LightPoint(HolyLightUIPanel ctrl, GameObject obj)
		{
		}

		public void Shoot(Vector3 startPos, Vector3 endPos, int pathPointCount, float shootTime, Vector2 offsetRange, float stayTime)
		{
		}

		public void Close()
		{
		}
	}

	public DxxText titleText;

	public DxxText timeText;

	public DxxText okBtnText;

	public DxxText matNumText;

	public DxxText taskBtnText;

	public DxxText limtText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl bgBtn;

	public ButtonCtrl allInfoBtn;

	public ButtonCtrl taskBtn;

	public ButtonCtrl okBtn;

	public ButtonCtrl exchangeBtn;

	public HolyLightAllRewardPart allRewardPart;

	public PropOneEquip oneEquip;

	public HolyLightStageRewardPart stageRewardPart;

	public HolyLightSkillTips holyLightSkillTips;

	public HolyLightBigRewardSelectPanel bigRewardSelectPanel;

	public HolyLightDetailsPanel detailsPanel;

	public HolyLightInfoPanel infoPanel;

	public RedNodeCtrl okRed;

	public RedNodeCtrl taskRed;

	public Image matIcon;

	public GameObject effect;

	public ButtonCtrl treasurePrivilegeBtn;

	public DxxText treasureLevelText;

	public TreasurePrivilegePanel treasurePrivilegePanel;

	public GameObject heroEffect;

	public GameObject lightPointCopyOne;

	public Transform lightPointParent;

	[Header("光点个数")]
	public int pointCount;

	[Header("光点路径点数(飞行平滑度)")]
	public int pathPointCount;

	[Header("光点飞行时间")]
	public float shootTime;

	[Header("光点偏移范围")]
	public Vector2 offsetRange;

	[Header("光点发射间隔")]
	public float shellsIntervalTime;

	[Header("光点到达后停留时间")]
	public float stayTime;

	[Header("光点到达随机范围")]
	public Vector2 targetRange;

	private TimeLineContainer timeLine;

	private List<LightPoint> shellsPool;

	protected override void OnInit()
	{
	}

	private void ClickOK()
	{
	}

	private void ClickAllInfo()
	{
	}

	private void ClickTask()
	{
	}

	private void ClickSkill(Vector3 pos, int skillId)
	{
	}

	private void ClickInfo()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnReqAllRewardCallBack(int type, Vector3 pos)
	{
	}

	private void OnReqInfoCallBack(bool obj)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void RefreshHeroEffect()
	{
	}

	private void RefreshSelectReward()
	{
	}

	public void RefreshRed()
	{
	}

	public void RefreshBtn()
	{
	}

	private void RefreshTreasureEntry()
	{
	}

	private void freshTime()
	{
	}

	private LightPoint GetShells()
	{
		return null;
	}

	private void OnShellsRecyle(LightPoint shell)
	{
	}

	private void StopShoot()
	{
	}

	private void ShootInternal(Vector3 startPos, Vector3 endPos)
	{
	}

	private LightPoint ShootShells(Vector3 startPos, Vector3 endPos)
	{
		return null;
	}
}
