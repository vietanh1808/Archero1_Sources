using UnityEngine;

public class SkillAlone1725 : SkillAloneWuKongAI
{
	protected float stretchStickThickness;

	protected float longDis;

	public const string STRETCHING_PRE_ANIM = "SkillAttack02Prev";

	public const string STRETCHING_END_ANIM = "SkillAttack02End";

	public const string STRETCHING_ANIM = "SkillAttack02Streching";

	private float StretchingPreAnimTime;

	private float StretchingEndAnimTime;

	private float StretchingAnimTime;

	public float maxSpeedPercent;

	public BulletBase stretchBullet;

	protected override float StickThickness => 0f;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void parseDisArgs(string[] args)
	{
	}

	protected override void addClips()
	{
	}

	private void RunWuKongStretchAI()
	{
	}

	public ActionBasic.ActionBase GetActionStretchWrapper()
	{
		return null;
	}

	public BulletBase createStretchBullet(Vector3 bulletPos, Vector3 bulletDir, float sizeZ)
	{
		return null;
	}

	public (Vector3, float) getStretchEndScale()
	{
		return default;
	}

	public void KillBullets()
	{
	}

	private void initStretchAnims()
	{
	}
}
