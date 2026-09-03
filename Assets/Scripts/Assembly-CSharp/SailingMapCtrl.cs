using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;

public class SailingMapCtrl : MonoBehaviour
{
	private class TimeLineRunAllShip : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineRunAllShip _003C_003E4__this;

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
			public _003CWait_003Ed__3(int _003C_003E1__state)
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

		private SailingMapCtrl m_Ctrl;

		private float runTime;

		public TimeLineRunAllShip(SailingMapCtrl mapCtrl, float _speed, float _runTime)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__3))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	private class TimeLineToNormal : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineToNormal _003C_003E4__this;

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
			public _003CWait_003Ed__2(int _003C_003E1__state)
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

		private SailingMapCtrl m_Ctrl;

		public TimeLineToNormal(SailingMapCtrl mapCtrl)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__2))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	private class TimeLineToFolloiwSelf : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineToFolloiwSelf _003C_003E4__this;

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
			public _003CWait_003Ed__2(int _003C_003E1__state)
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

		private SailingMapCtrl m_Ctrl;

		public TimeLineToFolloiwSelf(SailingMapCtrl mapCtrl)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__2))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	private class TimeLineToHarbor : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineToHarbor _003C_003E4__this;

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
			public _003CWait_003Ed__3(int _003C_003E1__state)
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

		private SailingMapCtrl m_Ctrl;

		private float islandOffset;

		public TimeLineToHarbor(SailingMapCtrl mapCtrl, float islandOffset)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__3))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	private class TimeLineIslandShow : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineIslandShow _003C_003E4__this;

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
			public _003CWait_003Ed__7(int _003C_003E1__state)
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

		private SailingMapGoodCtrl beastIsland;

		private SailingMapCtrl m_Ctrl;

		private float speedland;

		private float showTimeland;

		private float speedsailing;

		private float showTimesailing;

		public TimeLineIslandShow(SailingMapCtrl mapCtrl, float landOri, float offsetland, float _showTimeland, float offsetsailing, float _showTimesailing)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__7))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	public class TimeLineShipAddSpeed : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWait_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineShipAddSpeed _003C_003E4__this;

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
			public _003CWait_003Ed__4(int _003C_003E1__state)
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

		private float speed;

		private float addDurtion;

		private float duration;

		public TimeLineShipAddSpeed(SailingMapGoodCtrl ship, float AddDistance, float duration, float addDurtion)
		{
		}

		[IteratorStateMachine(typeof(_003CWait_003Ed__4))]
		private IEnumerator Wait()
		{
			return null;
		}
	}

	public SailingMapEventHandler sailingMapEventHandler;

	public SailingMapGoodView copyOne;

	public SailingMapLineCtrl lineCopyOne;

	public SailingMapBgCtrl skyBgPic;

	public SailingMapBgCtrl cloundBgPic;

	public SailingMapBgCtrl islandBgPic;

	public SailingMapBgCtrl WaterBgPic;

	public SailingMapBgCtrl MountainBgPic;

	public float OneScreenMile;

	public float HDragToMapRate;

	private float ToSelfPosRate;

	public Action<bool, bool> onShowLocal;

	public Action OnChangeEvent;

	private List<SailingMapLineCtrl> lines;

	private double m_CurShowPos;

	private SailingMapState state;

	private SailingMapGoodCtrl selfShip;

	private SailingMapGoodCtrl targetGoodCtrl;

	private int selfDataIndex;

	private List<SailingMapGoodCtrl> otherShips;

	private Queue<SailingMapGoodView> shipViewPools;

	private SailingMapGoodCtrl.SailingMapGoodData[] shipdatas;

	private ShipBattle_WarStep m_Config;

	private float[][] linesConfig;

	private int schedule;

	private bool m_IsClear;

	private bool m_IsOpening;

	private TimeLineContainer timeLine;

	private SailingWarStage CurWarStage;

	private bool isPlayedBossAni;

	private float ToSelfTime;

	private float offsetDis;

	public float PosToSelfRate => 0f;

	public float DragToMapRate => 0f;

	private float maxDistance => 0f;

	private int selfChannel => 0;

	public void Init()
	{
	}

	public void Open(int step = 1, bool isOpenClear = false)
	{
	}

	public void Refresh(int step = 1)
	{
	}

	private void InitConfig(int step)
	{
	}

	public void InitBgs()
	{
	}

	private void InitLines()
	{
	}

	private void InitShipdatas()
	{
	}

	private void InitShips()
	{
	}

	private int GetShipLineCount()
	{
		return 0;
	}

	public void InitShipInHarbor()
	{
	}

	public void ClearShips()
	{
	}

	public void Close()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateShipPos()
	{
	}

	private void UpdateCurShowPos()
	{
	}

	private void UptateShips()
	{
	}

	private void UpdateBgs()
	{
	}

	private void UpdateEventTime()
	{
	}

	public void ToSelfPos()
	{
	}

	public void SetState(SailingMapState toState)
	{
	}

	public SailingMapState GetState()
	{
		return SailingMapState.None;
	}

	public void ShowPirateGiftShip(bool isShow)
	{
	}

	public void ShowEnemyShipShip(int difficultId, bool isShow, SailingManager.SailingLogActionType actionType = SailingManager.SailingLogActionType.Battle)
	{
	}

	public SailingMapGoodCtrl ShowBeastLand(float offset, SailingWarEventType _eventType = SailingWarEventType.None)
	{
		return null;
	}

	private void AddMapGoodCtrl(SailingMapGoodCtrl goodCtrl, int channel)
	{
	}

	private void RemoveMapGoodCtrl(SailingMapGoodCtrl goodCtrl)
	{
	}

	private void BeginDrag(Vector2 pos)
	{
	}

	private void Drag(Vector2 offset)
	{
	}

	private void EndDrag(Vector2 pos)
	{
	}

	private bool IsArrive(float distance)
	{
		return false;
	}

	private SailingMapGoodView GetMapShipView()
	{
		return null;
	}

	private void RecyleMapShipView(SailingMapGoodView view)
	{
	}

	public void OnPopClose()
	{
	}

	private bool CheckIsOnlySailingMain()
	{
		return false;
	}

	public void OnSailingLogShow(bool isShow)
	{
	}

	public void InitStage()
	{
	}

	private void SwitchToNextStageInternal()
	{
	}

	public void ToNormal()
	{
	}

	public void InitEvent()
	{
	}

	private void SwitchToEventInternal()
	{
	}

	public void ToIsLand()
	{
	}

	public void ToGoast()
	{
	}

	public void ToBoss()
	{
	}

	public void ToTreasure()
	{
	}

	public void AddSelfDistance(float AddDistance)
	{
	}

	public void SetSelfBoxShow(bool isShow, string boxImg)
	{
	}

	public void AddSailingMonsterComming(SailingMonsterBossCtrl monster)
	{
	}

	public void RemoveSailingMonsterComming()
	{
	}

	public void ShowSailingMonsterComming(bool isShow)
	{
	}

	public void PlayMonsterAttackAni(RectTransform target)
	{
	}

	public void SatrtPlayMonsterAttackAni(RectTransform target)
	{
	}

	public void EndPlayMonsterAttackAni()
	{
	}

	private bool OnCheckGuideCondition(SailingGuideManager.GuideModule module)
	{
		return false;
	}
}
