using UnityEngine;
using UnityEngine.UI;

public class PauseUISkillIconCtrl : MonoBehaviour
{
	protected Image image;

	private DxxText Text_SkillID;

	private Image bgImage;

	[SerializeField]
	private Image _imgHead;

	private int skillId;

	private void Awake()
	{
	}

	public virtual void Init(int SkillID, int headId = 0)
	{
	}

	public void onButtonClick()
	{
	}
}
