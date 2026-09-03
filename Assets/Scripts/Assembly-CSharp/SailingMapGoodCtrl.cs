using System;
using GameProtocol;
using UnityEngine;

public class SailingMapGoodCtrl
{
	public enum MapGoodType
	{
		ship = 0,
		pirateGiftShip = 1,
		beastIsland = 2,
		sailingMonsterComming = 3
	}

	public class SailingMapGoodData
	{
		public MapGoodType goodType;

		public SailingShipPartData shipData;

		public CShipBattleRank rankData;

		public double distance;

		public float speed;

		public bool isSelf;

		public bool isArrived;

		public string BoxImage;

		public bool isPlayer;

		public SailingMonsterBossCtrl sailingMonsterBossCtrl;

		public bool isShow;

		public float StartAttMonsterTime;

		public RectTransform target;

		public bool isAttMonstering;

		public SailingWarEventType eventType;
	}

	private double m_Position;

	public float PosToSelfRate;

	private float Speed;

	private SailingMapGoodView view;

	public Func<SailingMapGoodView> GetViewItem;

	public Action<SailingMapGoodView> RecycleViewItem;

	public Action<SailingMapGoodView> OnShowView;

	public Action<SailingMapGoodCtrl> OnClose;

	public Action OnChangeSpeedState;

	public Action OnUpdate;

	public SailingMapGoodData mData;

	public bool isUpdateDistance;

	public int lineIndex;

	private float toSpeed;

	private float acceleration;

	public SailingMapGoodCtrl(SailingMapGoodData data, double pos, float _PosToSelfRate)
	{
	}

	public void UpdatePos()
	{
	}

	public double GetPos()
	{
		return 0.0;
	}

	public void SetPos(double distance)
	{
	}

	public float GetSpeed()
	{
		return 0f;
	}

	public void RefreshUIPositon(double mapShowPosX)
	{
	}

	public void AddSpeed(float toSpeed, float acceleration = 0.1f)
	{
	}

	public void SetSpeed(float toSpeed)
	{
	}

	public void SetNativeSpeed(float acceleration = 0.1f)
	{
	}

	public void Refresh()
	{
	}

	private void UnInitView()
	{
	}

	public void Close()
	{
	}

	public void PlayShipMonsterAttackAni(RectTransform target)
	{
	}
}
