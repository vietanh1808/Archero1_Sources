using System.Collections.Generic;

public class SkillAlone1222 : SkillAloneBase
{
	private enum SkinEnum
	{
		Red = 0,
		Blue = 1,
		Green = 2,
		Yellow = 3
	}

	private const int totalSkinCount = 4;

	private Dictionary<int, int> skinProbabilityDict;

	private string[] skillArgs;

	protected string[] skillAloneArgs;

	protected float originalOwlElfBornProbability;

	protected float owlElfBornProbability;

	private int permittedMaxOwlElfCount;

	private float callOwlElfTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onHitEnemy(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void initSkinProbabilityDict()
	{
	}

	private int getRandomSkinType(Dictionary<int, int> probablityDict)
	{
		return 0;
	}

	private bool checkIfIllegalSkinType(int _skinId)
	{
		return false;
	}

	private void ChangeCallRate(float delta)
	{
	}
}
