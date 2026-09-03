using System.Collections.Generic;

public class EntityPet4013 : EntityPetBase
{
	public const string ANIM_JUMP = "jump";

	public const string ANIM_BIGJUMP = "big_jump";

	public bool IsJumping { get; set; }

	public float AtkPercent { get; set; }

	public float DeltaAtkPercent { get; set; }

	public int BulletDebuffId { get; set; }

	public float criteRatePercent { get; set; }

	public float baseCustomCritValuePercent { get; set; }

	public float critValuePercent { get; set; }

	public float SelfDamageBoostPercent { get; set; }

	public override void OnAfterAnimCtrlInitialized()
	{
	}

	protected override List<string> getAllAnims()
	{
		return null;
	}
}
