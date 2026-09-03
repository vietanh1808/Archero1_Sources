using System.Collections.Generic;
using UnityEngine;

public class NewPlay126MonsterEntityGroup : MonoBehaviour
{
	[SerializeField]
	private NewPlay126MonsterEntityGroupItem groupItem;

	[SerializeField]
	private List<Transform> monsterCreatePo;

	private List<NewPlay126MonsterEntityGroupItem> createItems;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private NewPlay126Manager NewPlay126Manager => null;

	private NewPlay126MonsterEntityGroupData NewPlay126MonsterEntityGroupData => null;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh()
	{
	}

	public void OnClose()
	{
	}

	private void RefreshModel()
	{
	}

	public void Deinit()
	{
	}
}
