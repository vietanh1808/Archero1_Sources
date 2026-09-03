using System.Collections.Generic;
using UnityEngine;

public class RelicSetCtrl : MonoBehaviour
{
	private LocalSave.EquipOne mRelicOne;

	private LocalUnityObjctPool mPool;

	public RelicSetItemCtrl setItemCache;

	private List<int> collectedRelicIds;

	private List<int> allRelicIds;

	public DxxText txt_setInfo;

	public RectTransform itemsParent;

	public void Init(LocalUnityObjctPool pool)
	{
	}

	public void refreshUI(LocalSave.EquipOne relicOne)
	{
	}

	private void refreshData()
	{
	}

	private void refreshTxtSetInfo()
	{
	}

	private void refreshItems()
	{
	}
}
