using System.Collections.Generic;
using UnityEngine;

public class PetSkillBtnGroup : MonoBehaviour
{
	[SerializeField]
	private List<Transform> rightItemPos;

	[SerializeField]
	private List<Transform> leftItemPos;

	[SerializeField]
	private PetSkillBtn petSkillBtn;

	private List<BattlePetVO> battlePetVOs;

	private List<PetSkillBtn> curCreateList;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private bool useRight;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(List<BattlePetVO> battlePetVOs, bool useRight)
	{
	}

	private void RefreshItem()
	{
	}
}
