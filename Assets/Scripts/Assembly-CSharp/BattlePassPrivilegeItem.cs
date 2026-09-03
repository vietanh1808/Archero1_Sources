using UnityEngine;

public class BattlePassPrivilegeItem : MonoBehaviour
{
	[SerializeField]
	private DxxText txtPrivilege;

	[SerializeField]
	private DxxImage iconPrivilege;

	[SerializeField]
	private DxxImage iconBg;

	public void Init(LocalSave.NewBpPrivilegeItemData data, bool isNormal)
	{
	}
}
