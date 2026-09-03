using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipGameUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingShipGameUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__67(int _003C_003E1__state)
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
	private SailingShipScene shipScene;

	[SerializeField]
	private SailingShipEntity shipEntity;

	[SerializeField]
	private SailingShipWarning shipWarning;

	[SerializeField]
	private SailingShipBullet shipBullet;

	[SerializeField]
	private RectTransform missPos;

	[SerializeField]
	private Transform bulletPool;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private SailingShipWarningItem selfItem;

	[SerializeField]
	private SailingShipWarningItem enemyItem;

	[SerializeField]
	private SailingShipPlayerBlood selfBlood;

	[SerializeField]
	private SailingShipPlayerBlood enemyBlood;

	[SerializeField]
	private GameObject battleInfoGroup;

	[SerializeField]
	private ButtonCtrl jumpBattleBtn;

	[SerializeField]
	private ButtonCtrl speedUpBattleBtn;

	[SerializeField]
	private DxxText jumpBattleBtnName;

	[SerializeField]
	private SailingShipBattleBuffItem buffItem;

	[SerializeField]
	private Transform selfBuffParent;

	[SerializeField]
	private Transform enemyBuffParent;

	[SerializeField]
	private SailingShipNumFlyAni numFlyAni;

	[SerializeField]
	private Transform numFlyParent;

	[SerializeField]
	private SailingShipBattleBuffDesc selfBuffDesc;

	[SerializeField]
	private SailingShipBattleBuffDesc enemyBuffDesc;

	[SerializeField]
	private Image speedUpIcon;

	[SerializeField]
	private RectTransform topContent;

	[SerializeField]
	private SailingShipBossBlood bossBlood;

	private List<SailingShipBattleBuffItem> _selfBuffItems;

	private List<SailingShipBattleBuffItem> _enemyBuffItems;

	private LocalUnityObjctPool pool;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private const int HitHullXRange = 125;

	private const int HitHullYRange = 35;

	private const int JumpGameDisabledTime = 5;

	private int jumpGameDisabledLeftTime;

	private Dictionary<string, SailingShipBattleBuffItem> _dicBuffs;

	private SailingShipManager SailingShipManager => null;

	private SailingShipGameData SailingShipGameData => null;

	private SailingShipEntityData SailingShipEntityData => null;

	private SailingShipWarningData SailingShipWarningData => null;

	private SailingShipBattleResultData SailingShipBattleResultData => null;

	private long GameLeftTime => 0L;

	private float CurSpeedUp => 0f;

	private int CurSpeedUpIndex { get; set; }

	private void InitPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnDeInit()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshActive()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshBuffItem()
	{
	}

	private void RefreshPlayerBlood(bool isNeedAni, bool isFromOpen = false, bool isJumpGame = false)
	{
	}

	private void RefreshSpeedUp(float speed)
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__67))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void SetCountDownText(string text)
	{
	}

	private void StartBattleMsg()
	{
	}

	private void ShipSendBullet(SailingShipBattleFighter fighter, float bulletFlyTime, int sendPosSlot, int targetPosSlot)
	{
	}

	private void ShpFlyNum(SailingShipBattleFighter fighter, int hitPosSlot, float num, bool isCrit)
	{
	}

	private void ClickJumpBattleBtn()
	{
	}

	private void ClickSpeedUpBattleBtn()
	{
	}

	private void RefreshSpeedIcon()
	{
	}

	private void ResetSpeedUp()
	{
	}

	private void RefreshJumpGame()
	{
	}

	private void InitAnchored()
	{
	}
}
