using UnityEngine;
using UnityEngine.UI;

public class PetSkillBtn : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image fillIcon;

	[SerializeField]
	private ParticleSystem ready;

	[SerializeField]
	private ParticleSystem cast;

	private BattlePetVO data;

	private Material grayMat;

	private bool isInit;

	private void Init()
	{
	}

	public void Refresh(BattlePetVO data)
	{
	}

	private void RefreshAction()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshFillImage(float curValue)
	{
	}

	private void RefreshParticle(PetEnergyVO.PetSkillStatus status)
	{
	}

	public void Recycle()
	{
	}

	private void OnEnergyChange(float curCount)
	{
	}

	private void OnPetSkillStatusChange(PetEnergyVO.PetSkillStatus status)
	{
	}
}
