using UnityEngine;
using UnityEngine.UI;

public class RelicAttrRichInfoCtrl : MonoBehaviour
{
	private RelicAttrInfoCtrl.AttrType curAttrType;

	private LocalSave.EquipOne mRelicOne;

	private LocalUnityObjctPool mPool;

	public Transform infoParent;

	public DxxText txt_title;

	public EquipOneCtrl relicOneCtrl;

	public DxxImage img_lock;

	public Image img_head;

	public RectTransform starTrans;

	public DxxText txt_star;

	public DxxText txt_level;

	public DxxText txt_info;

	public void Init(LocalUnityObjctPool _Pool)
	{
	}

	public void RefreshUI(RelicAttrInfoCtrl.AttrType _curAttrType, LocalSave.EquipOne one)
	{
	}

	private void refreshTxtTitle()
	{
	}

	private string getHeadIconStr(int heroId)
	{
		return null;
	}

	private void refreshLockImg()
	{
	}

	private void refreshTxtInfos()
	{
	}

	private void setAllInvisible()
	{
	}
}
