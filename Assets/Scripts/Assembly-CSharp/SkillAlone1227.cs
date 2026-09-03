using UnityEngine;

public class SkillAlone1227 : SkillAloneBase
{
	private int m_nHitRange;

	private int m_nMax;

	private float m_fRate;

	private int m_nCnt;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	public void AddPumpkin(int _ClassID, Vector3 _pos)
	{
	}

	public void SyncPumpskinCommand(int _ClassID, Vector3 _pos)
	{
	}

	private void OnCtrlDeInit(SkillAlone1227Ctrl ctrl)
	{
	}
}
