using UnityEngine;

public class BattleDailyWaveCtrl : MonoBehaviour
{
	public GameObject SurvivalChild;

	public GameObject WaveChild;

	public DxxText Text_Wave;

	public DxxText Text_Survival;

	private BattleDailyWaveData waveData;

	private float survivalStartTime;

	private float waveStartTime;

	private bool ifKillAll;

	public void SetActive(bool survivalActive, bool waveActive)
	{
	}

	public void SetInfo(BattleDailyWaveData data)
	{
	}

	protected virtual void OnInit()
	{
	}

	private void Update()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	private void SetWaveTime(int time)
	{
	}

	private void SetSurvivalTime(int time)
	{
	}

	private void RefreshUI(BattleDailyWaveData data)
	{
	}

	public virtual void Deinit()
	{
	}
}
