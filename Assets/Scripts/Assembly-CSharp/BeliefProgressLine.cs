using System.Collections.Generic;
using UnityEngine;

public class BeliefProgressLine : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> line;

	[SerializeField]
	private List<GameObject> upgradeLine;

	public void InitLineWidth(BeliefSkillItemData data, float width, float height)
	{
	}

	public void Refresh(BeliefTalentLineDir lineDir, BeliefTalentLineDir lineCanUpgrade)
	{
	}
}
