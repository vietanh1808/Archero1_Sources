using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
	public enum GameState
	{
		eMain = 0,
		eGaming = 1
	}

	public class EndLessData
	{
		private const string tag = "[GameManager.EndLessData] ";

		public List<int> changeHeroBuffList;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public void AddChangeHeroBuff(int buffid)
		{
		}

		private void onChangeHero(int heroid)
		{
		}

		private void debug(string value, params object[] args)
		{
		}
	}

	private RoomState roomState;

	private int m_nShowJoyCnt;

	private int talentId;

	private int skillId;

	private int sickId;

	private GameObject MoveJoy => null;

	public RoomState RoomState => RoomState.Invalid;

	public GameState gameState { get; private set; }

	public EndLessData mEndless { get; private set; }

	public void Release()
	{
	}

	private void Init()
	{
	}

	public void SetRoomState(RoomState state)
	{
	}

	public void SetRunning()
	{
	}

	public void SetGameState(GameState state)
	{
	}

	public void StartGame()
	{
	}

	public void EndGame()
	{
	}

	public void ShowJoy(bool show)
	{
	}

	public void RemoveJoy()
	{
	}

	public void JoyEnable(bool enable)
	{
	}

	public void SaveHeirChooseData(int talentId, int skillId, int sickId)
	{
	}

	private void init_endless()
	{
	}

	private void deinit_endless()
	{
	}
}
