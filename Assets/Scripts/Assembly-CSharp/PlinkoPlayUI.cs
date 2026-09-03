using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PlinkoPlayUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CspawnBalls_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<PlinkoBallData> paths;

		public PlinkoPlayUI _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private int _003Cindex_003E5__3;

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
		public _003CspawnBalls_003Ed__25(int _003C_003E1__state)
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

	public PlinkoActUIPanel uiPanel;

	public PlinkoMap pkoMap;

	public PlinkoConfig PkoConfig;

	public PlinkoHoleItem[] holeItems;

	private LocalUnityObjctPool ballPool;

	[SerializeField]
	private GameObject cpBall;

	private const int SpeedUpTime = 3;

	private bool isAuto;

	private bool needSwitchRound;

	private bool roundSwitching;

	public Image PlayBG;

	public Image PlayRhombus;

	public Image PlayLightTop;

	public GameObject UIMask;

	public Image PlayBG_Mask;

	public Image PlayRhombus_Mask;

	public Image PlayLightTop_Mask;

	public GameObject Mask;

	private Canvas canvas;

	private int preSort;

	private int nextSort;

	private int flyCount;

	[HideInInspector]
	private Dictionary<int, PlinkoBallItem> ballDropDict => null;

	public void onInit()
	{
	}

	public void onOpen()
	{
	}

	public void onClose()
	{
	}

	public void onHandleNotification(INotification notification)
	{
	}

	public void onLanguaged()
	{
	}

	private void freshHoleItems()
	{
	}

	private bool checkPopRewardWindow(Action action = null)
	{
		return false;
	}

	public void SpawnBall(PlinkoBallData ballData)
	{
	}

	private void PlayBallDropAnimation(int ballId)
	{
	}

	public void PlayBallFreeDropAnimation(Vector2Int pos, int ballIndex, Action callback, bool speedUp = false)
	{
	}

	public void PlayCylinderEffect(Vector2Int pos, int ballId)
	{
	}

	public void PlayBallNormalDropAnimation(Vector2Int pos, PlinkoMoveType moveType, PlinkoMoveType nextMoveType, int ballIndex, Action callback, bool speedUp = false)
	{
	}

	public void PlayBallRotateAnimation(PlinkoMoveType moveType, int ballIndex, bool speedUp = false)
	{
	}

	public void RecycleBall(int ballIndex)
	{
	}

	public void SpawnBalls(List<PlinkoBallData> paths)
	{
	}

	[IteratorStateMachine(typeof(_003CspawnBalls_003Ed__25))]
	private IEnumerator spawnBalls(List<PlinkoBallData> paths)
	{
		return null;
	}

	private void ballDropEnd(int ballId)
	{
	}

	private void nextRound()
	{
	}

	private void clearBalls()
	{
	}

	private void initPlayData()
	{
	}

	public void setCylinderItems()
	{
	}

	public void switchCylinderItems()
	{
	}

	private void setPlayBG(int round)
	{
	}

	private void setPlayBGMask(int round)
	{
	}

	private void switchRound()
	{
	}

	private void readyFlyInfo()
	{
	}

	private void resetCanvas()
	{
	}

	private void closeCurrency()
	{
	}

	private void fly(Vector3 pos, int ballId)
	{
	}
}
