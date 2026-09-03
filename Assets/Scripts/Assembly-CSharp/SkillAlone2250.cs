using UnityEngine;

public class SkillAlone2250 : SkillAlonePetBase
{
	private float addPowerLayerHpPercent;

	private int addMaxPowerLayer;

	private int addPowerLayerFirePercent;

	private int addPowerLayerAttackPercent;

	private int rebornReachLayer;

	private int rebornHpPercentPerLayer;

	private int rebornBuffId;

	private float perLevelAddFirePercent;

	private float perLevelAddAttackPercent;

	private float perLevelRebornHpPercentPerLayer;

	public const int SkillEffectID = 2250;

	private long haveAddFirePercent;

	private long haveAddAttackPercent;

	private ActionRebornUpdate rebornUpdate;

	private GameObject skillEffect;

	protected LocalSave.Skill2250VO Skill2186VO => null;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	private void AddProperty()
	{
	}

	private void RemoveProperty()
	{
	}

	private void CheckSkillEffectStatus()
	{
	}

	protected virtual float GetLayerEffectScale()
	{
		return 0f;
	}

	private void OnChangeHPHandler(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	protected virtual void OnReborn()
	{
	}
}
