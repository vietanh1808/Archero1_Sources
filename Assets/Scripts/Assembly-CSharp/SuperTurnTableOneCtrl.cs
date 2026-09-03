using UnityEngine;
using UnityEngine.UI;

public class SuperTurnTableOneCtrl : MonoBehaviour
{
	public Transform child;

	public Image Image_Icon;

	public DxxText Text_Value;

	public ParticleSystem chooseEff;

	public SuperTurntableData mData { get; private set; }

	public void Init(SuperTurntableData data)
	{
	}

	public void playEff()
	{
	}
}
