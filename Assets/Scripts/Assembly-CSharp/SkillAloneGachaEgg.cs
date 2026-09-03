using UnityEngine;

public class SkillAloneGachaEgg : SkillAloneBase
{
	private float maxDis;

	protected int buffId;

	protected GameObject goGachaEgg;

	protected bool roomGachaEggCreated;

	protected bool roomGachaEggOpened;

	protected bool isEggCreateEffectPlaying;

	private bool IsMoving;

	private string updateName;

	protected Vector3 oldPos;

	protected Vector3 originalPos;

	protected float curDistance;

	private float validDistance;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void parseArgs0(string[] args)
	{
	}

	private void onMove(bool isMoving)
	{
	}

	private void onUpdate(float delta)
	{
	}

	protected virtual void OnUpdateInternal(float delta)
	{
	}

	protected void CheckMovingDis()
	{
	}

	protected void CreateGachaEgg()
	{
	}

	protected void CreateGachaEggInternal(Vector3 birthPos)
	{
	}

	protected virtual void OnGachaEggCreated(Vector3 birthPos)
	{
	}

	protected virtual void OnGachaEggCleared()
	{
	}

	protected void SyncCreateGachaEgg(Vector3 pos)
	{
	}

	protected void SyncClearGachaEgg()
	{
	}

	protected void ClearGachaEggWrapper()
	{
	}

	protected void ClearGachaEgg()
	{
	}

	private GachaEggCDSlider createSlider()
	{
		return null;
	}
}
