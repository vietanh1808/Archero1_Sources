using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

public class EquipCombineParent : MonoBehaviour
{
	public GameObject child;

	[FormerlySerializedAs("mCombineBG")]
	public List<GameObject> _combineMaterialRoots;

	public GameObject copychoose;

	public Action<int> OnCombineDown;

	private int width;

	private LocalUnityObjctPool _pool;

	private string _uniqueId;

	[HideInInspector]
	public string[] chosenUidsByPos;

	public GameObject resultContainer;

	public EquipCombineCtrl _equipCombineCtrl;

	public GameObject targetRoots;

	private const int DefaultMatCnt = 2;

	private EquipOneCtrl _equipOneCtrl;

	private Vector3 firstMatPos;

	private Vector3 secondMatPos;

	public GameObject firstArrow;

	public GameObject RightArrow;

	private static DelegateBridge __Hotfix0_get_targetEquipOne;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_SetMainMaterialData;

	private static DelegateBridge __Hotfix0_GetEmptyMaterialPos;

	private static DelegateBridge __Hotfix0_GetPrevMaterialPos;

	private static DelegateBridge __Hotfix0_GetScale;

	private static DelegateBridge __Hotfix0_GetPosition;

	private static DelegateBridge __Hotfix0_UpdateAll;

	private static DelegateBridge __Hotfix0_ShowBatchCombineResult;

	private static DelegateBridge __Hotfix0_ClearBatchCombineResult;

	private static DelegateBridge __Hotfix0_isInGroup;

	private static DelegateBridge __Hotfix0_isInPos;

	private static DelegateBridge __Hotfix0_FindEmptyPos;

	private static DelegateBridge _c__Hotfix0_ctor;

	private EquipOneCtrl targetEquipOne => null;

	private void Awake()
	{
	}

	public void SetMainMaterialData(int materialNeeded, LocalSave.EquipOne data)
	{
	}

	public int GetEmptyMaterialPos(bool includeFake)
	{
		return 0;
	}

	public int GetPrevMaterialPos(string uid, int totalCount)
	{
		return 0;
	}

	public float GetScale(int index)
	{
		return 0f;
	}

	public Vector3 GetPosition(int index)
	{
		return default;
	}

	public void UpdateAll()
	{
	}

	private void ShowBatchCombineResult(bool toShow)
	{
	}

	private void ClearBatchCombineResult()
	{
	}

	private int isInGroup(CombineMaterialDataGroup group, string uid)
	{
		return 0;
	}

	private int isInPos(string uid)
	{
		return 0;
	}

	private int FindEmptyPos()
	{
		return 0;
	}
}
