using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MeadowBattleMonsterItem : MonoBehaviour
{
	public ButtonCtrl Btn_Monster;

	public DxxText text_MonsterName;

	public Image image_monster;

	public Image image_bg;

	public Image image_star;

	public RectTransform icon_grids;

	public DxxText txt_star;

	public GameObject MaskContainer;

	public bool IsSelected;

	private Farm_BattleMonster battleMonster_meta;

	[HideInInspector]
	public LocalSave.MonsterData MonsterData;

	public Farm_BattleMonster BattleMonsterData => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	private void init_image_monster()
	{
	}

	public void InitByData(LocalSave.MonsterData _data)
	{
	}

	public void Refresh()
	{
	}
}
