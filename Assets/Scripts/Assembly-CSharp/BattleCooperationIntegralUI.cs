using Cooperation;
using DamageTool;
using UnityEngine;
using UnityEngine.UI;

public class BattleCooperationIntegralUI : MonoBehaviour
{
	public DxxText integralNumber;

	public Image faceIcon;

	public Image boderIcon;

	public Image uparow;

	private DamageReCount.KillObject _killObject;

	private bool isShowDeadIcon;

	public EntityBase entity { get; set; }

	public bool IsSelf { get; set; }

	public int ranking { get; set; }

	public float topScale { get; set; }

	public Vector3 rankPostion { get; set; }

	public CooperationScoreObject scoreObject { get; set; }

	public int score => 0;

	public DamageReCount.KillObject killObject => null;

	public void Init()
	{
	}

	public void UpdateData()
	{
	}

	public void UpdateUI(float dt)
	{
	}

	public void PlayAnimation()
	{
	}

	private void TopAni()
	{
	}

	private void DownAni()
	{
	}
}
