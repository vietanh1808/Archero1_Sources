using UnityEngine;

public class SkillAlone1806 : SkillAloneBase
{
	private float hammerAtkCD;

	private float flashChainAtkCD;

	private FlashChainArgs flashChainArgs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void parseFlashChainArgs(string args)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void tryHammerHit(EntityBase enemy)
	{
	}

	private void createHammerHit(int weaponId, Vector3 bulletPos, Vector3 bulletDir)
	{
	}

	private void syncHammerHit(int weaponId, Vector3 bulletPos, Vector3 bulletDir)
	{
	}

	private void tryFlashChainHit(EntityBase enemy)
	{
	}

	private void createFlashChainHit(Vector3 bulletDir)
	{
	}

	private void syncFlashChainHit(Vector3 bulletDir)
	{
	}
}
