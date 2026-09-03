using UnityEngine;

public class ArtifactActivityTalentInfoCtrl : MonoBehaviour
{
	[SerializeField]
	private GameObject child;

	[SerializeField]
	private RectTransform bgparent;

	[SerializeField]
	private RectTransform arrowparent;

	[SerializeField]
	private RectTransform attrParent;

	[SerializeField]
	private DxxText Text_Name;

	[SerializeField]
	private DxxText Text_Locked;

	[SerializeField]
	private RectTransform left;

	[SerializeField]
	private RectTransform right;

	[SerializeField]
	private Animation ani;

	[SerializeField]
	private ArtifactActivityTalentStarOneCtrl _copyOne;

	private ArtifactActivityTalentOne _target;

	private LocalUnityObjctPool _pool;

	public void Init(ArtifactActivityTalentOne ctrl)
	{
	}

	public void Show(bool value)
	{
	}
}
