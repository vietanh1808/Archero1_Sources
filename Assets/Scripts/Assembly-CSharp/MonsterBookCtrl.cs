using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterBookCtrl : MonoBehaviour
{
	public DxxText Text_Title;

	public MonsterBookItem[] bookItems;

	public DxxText Text_Collect;

	public DxxText Text_CollectNum;

	public RectTransform collectPanel;

	public UILineCtrl TitleLine;

	public RectTransform noCollectPanel;

	public GameObject MaskState;

	public GameObject cpItem;

	public HorizontalLayoutGroup horizonLayout;

	public void init()
	{
	}

	public void OnClose()
	{
	}

	public void handleNotification(string key, object value)
	{
	}

	private void addMonster(LocalSave.MonsterData data, RectTransform parent, GameObject child)
	{
	}

	private void removeMonster()
	{
	}

	private void freshStarUP(LocalSave.MonsterData data)
	{
	}

	private void sortMonsters(List<LocalSave.MonsterData> list)
	{
	}

	private void changeBookItemState(int state)
	{
	}

	private void freshCollectPanel()
	{
	}
}
