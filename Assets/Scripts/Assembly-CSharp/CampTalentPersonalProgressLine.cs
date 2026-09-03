using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CampTalentPersonalProgressLine : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> line;

	[SerializeField]
	private List<GameObject> upgradeLine;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampTalentLineDir lineDir, CampTalentLineDir lineCanUpgrade)
	{
	}
}
