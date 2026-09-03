using System.Collections.Generic;

public class EntityPet4005 : EntityPetBase
{
	private const string ANIM_SKILL_PREV = "skillprev";

	private const string ANIM_SKILL_END = "skillend";

	public int ReboundCount { get; set; }

	public int ForSideCount { get; set; }

	public float AtkPercent { get; set; }

	public float DeltaAtkPercent { get; set; }

	public int BulletDebuffId { get; set; }

	public float criteRatePercent { get; set; }

	public float baseCustomCritValuePercent { get; set; }

	public float critValuePercent { get; set; }

	public override void OnAfterAnimCtrlInitialized()
	{
	}

	protected override List<string> getAllAnims()
	{
		return null;
	}
}
