using UnityEngine;
using UnityEngine.UI;

public class EggMonsterOne : MonoBehaviour
{
	public GameObject modelParent;

	[Header("是否可以走动")]
	public bool canAutoMove;

	private RectTransform middleTrans;

	private Transform modelTrans;

	private float modelAngle;

	private BodyMask mask;

	[HideInInspector]
	public int monsterid;

	public float speed;

	public float timeSpace;

	private float curTime;

	private float limitw;

	private float limith;

	public Button Button_Box;

	public void LoadMonster(int mid, RectTransform middle)
	{
	}

	public void PlayAnimation()
	{
	}

	public void Update()
	{
	}

	private void move()
	{
	}

	private void turn()
	{
	}

	private bool checkBounds()
	{
		return false;
	}

	public void resetScale(Vector3 v3)
	{
	}

	public void setOthers()
	{
	}

	public void setButtonTouch(bool touched)
	{
	}

	public void OnClickMonster()
	{
	}
}
