using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SingleNewChapterWaveVO
{
	[CompilerGenerated]
	private sealed class _003CCreateMonsterByWaves_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SingleNewChapterWaveVO _003C_003E4__this;

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
		public _003CCreateMonsterByWaves_003Ed__38(int _003C_003E1__state)
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

	private const string LOG_TAG = "[SingleNewChapterWaveVO]";

	public string[] WaveIDs;

	public string[] WaveIDs1;

	public int[] Several;

	public int[] Nest;

	public int CurMissionId;

	public int RoomId;

	public List<SingleWaveGoodVO> goodsList;

	private List<List<SingleWaveGoodVO>> goodsListMulti;

	private List<EntityBase> allMonstersPerWave;

	public RoomGenerateBase.RoomType roomType;

	private NewChapterWavesVO wavesVO;

	private int curGoodCount;

	private ActionBasic eventFinishDelayAction;

	private ActionBasic generateMonsterAction;

	private bool initialized;

	private bool isWaveGoodsCreated;

	private int maxGroupId;

	private float monsterBornInterval;

	public float WaveRefreshInterval;

	private Coroutine StartWaveCO;

	private bool isCreatingMonsters;

	private Vector3 deltaOffset;

	private List<EntityBase> monsterList;

	public float TotalMonsterTime;

	public float PerMonsterTime;

	public float waitBossTime;

	public bool IsWaveGoodsCreated => false;

	public bool IsCreatingMonsters => false;

	public SingleNewChapterWaveVO(NewChapterWavesVO _wavesVO)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void initRoomType()
	{
	}

	public bool IsEventWave()
	{
		return false;
	}

	public bool IsBossWave()
	{
		return false;
	}

	public bool IsNormalWave()
	{
		return false;
	}

	private void prepareWaveGoods()
	{
	}

	private void prepareWaveGoodsForWaveNewPlay()
	{
	}

	private void PrepareWaveGoodsFromConfig(int missionId, out int[] groupNum, out int[] monsterNum, out float bornInterval, out float waveInterval)
	{
		groupNum = null;
		monsterNum = null;
		bornInterval = default;
		waveInterval = default;
	}

	public void StartWave()
	{
	}

	public void StartWaveForWaveNewPlay()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateMonsterByWaves_003Ed__38))]
	private IEnumerator CreateMonsterByWaves()
	{
		return null;
	}

	private void cancelCallbacks()
	{
	}

	public void EndWave()
	{
	}

	public bool IsWaveEnd()
	{
		return false;
	}

	private void onEventNPCDisappear(EventWindowCtrl ctrl)
	{
	}

	private void onMonsterDead(EntityBase enemy)
	{
	}

	private void endWaveWrapper()
	{
	}

	private void createSingleMonster(EntityBase monster)
	{
	}

	private void createMonsters(List<SingleWaveGoodVO> destGoodsList)
	{
	}

	private void createSoliders(List<EntityBase> monsterList)
	{
	}

	private void createBoss(List<EntityBase> monsterList)
	{
	}

	private void createEvents()
	{
	}

	private GameObject createMonsterByGood(SingleWaveGoodVO goodVO)
	{
		return null;
	}

	private GameObject createEventByGood(SingleWaveGoodVO goodVO)
	{
		return null;
	}

	private void mockGoods()
	{
	}

	private void mockMonsters()
	{
	}

	private void mockBoss()
	{
	}
}
