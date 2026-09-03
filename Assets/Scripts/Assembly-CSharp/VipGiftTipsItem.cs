using UnityEngine;

public class VipGiftTipsItem : MonoBehaviour
{
	public DxxText txtVipLv;

	public DxxText txtVipName;

	public DxxText txtVipTips;

	public DxxText txtCrtLv;

	public DxxText txtMaxValueTips;

	public DxxImage imgVipLv;

	public DxxImage imgBg;

	public Sprite[] bgSprites;

	public GameObject goNormal;

	public void Init(int level, int count, VipPrivilegeType pType, bool isCrt = true, bool isMax = false)
	{
	}
}
