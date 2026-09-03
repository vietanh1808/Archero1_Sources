using UnityEngine;

public class BattleLevelWaveCtrl : MonoBehaviour
{
	public GameObject child;

	public DxxText Text_Wave;

	protected BattleLevelWaveData mData;

	protected float starttime;

	private int oldtime;

	private int newtime;

	public virtual void SetActive(bool value)
	{
	}

	public virtual void SetInfo(BattleLevelWaveData data)
	{
	}

	protected virtual void set_time(int time)
	{
	}

	private void Update()
	{
	}

	protected virtual void OnUpdate()
	{
	}

	public void Deinit()
	{
	}
}
