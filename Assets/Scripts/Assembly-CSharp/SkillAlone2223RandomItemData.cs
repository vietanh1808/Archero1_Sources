using System;

[Serializable]
public class SkillAlone2223RandomItemData
{
	public int RandomMin;

	public int RandomMax;

	public int RandomProb;

	public int EjectCount;

	public int[] AddSelfBuff;

	public int ConfirmValue;

	public static SkillAlone2223RandomItemData Create(int randomMin, int randomMax, int randomProb, int ejectCount, int[] addSelfBuff)
	{
		return null;
	}

	public bool IsNumInRange(int num)
	{
		return false;
	}

	public int GetRandomProb()
	{
		return 0;
	}

	public void UpdateConfirmValue(int minValue)
	{
	}

	public void SetConfirmValue(int value)
	{
	}
}
