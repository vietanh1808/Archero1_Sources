using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class EggMeadowBattlePanel : MonoBehaviour
{
	public VerticalLayoutGroup layoutGroup;

	public DxxText Text_Hp;

	public DxxText Text_Atk;

	public DxxText Text_SearchDir;

	public DxxText Text_SearchDistance;

	public DxxText Text_AtkSpeed;

	public DxxText Text_MovSpeed;

	private Farm_BattleMonster meta;

	private LocalSave.MonsterData mData;

	private const int MAX_STAR = 10;

	public void init(int monsterId)
	{
	}

	public void refreshUI()
	{
	}

	private string getMovSpeedContent()
	{
		return null;
	}

	private string getAtkSpeedContent()
	{
		return null;
	}

	private string getSearchDistanceContent()
	{
		return null;
	}

	private string getHpContent()
	{
		return null;
	}

	private string getAtkContent()
	{
		return null;
	}

	private string getSearchDirContent()
	{
		return null;
	}

	public string getKey(string key)
	{
		return null;
	}
}
