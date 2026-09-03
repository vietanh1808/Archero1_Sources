using System.Collections.Generic;

public class SkillAlone2180 : SkillAloneBase
{
	private int addBuffProb;

	private int addBuff1;

	private int addBuff2;

	private int addBuff3;

	private int addBuff4;

	private float skillDmgScale;

	private float skillRadius;

	private int skillDebuff;

	private List<int> originAllBuff;

	private List<int> combineBuff;

	private Dictionary<int, SkillAlone2180CombineBuffCtrl> allEnemyEffect;

	private Dictionary<int, List<int>> allEnemyHaveAddBuffEffect;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void HitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}

	private void CastSKill(EntityBase sender, EntityBase target)
	{
	}

	private void CastBuffSkill(EntityBase sender, EntityBase target, int curAddBuff)
	{
	}

	private void LoadCombineBuffEffect(EntityBase target, int addBuffID)
	{
	}

	private void RemoveBuffEffect(EntityBase target)
	{
	}

	private void CastBombSKill(EntityBase sender, EntityBase target)
	{
	}

	private void SendCastBuffSkillMsg(EntityBase sender, EntityBase target, int curAddBuff)
	{
	}

	private void SyncCastBuffSkillMsg(EntityBase sender, EntityBase target, int curAddBuff)
	{
	}

	private void SendCastBombSKillMsg(EntityBase sender, EntityBase target)
	{
	}

	private void SyncCastBombSKillMsg(EntityBase sender, EntityBase target)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
