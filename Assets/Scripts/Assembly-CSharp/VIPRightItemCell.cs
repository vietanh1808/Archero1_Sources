using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class VIPRightItemCell : UITableViewCell
{
	public Image Image_Icon;

	public DxxText Text_Effect;

	public GameObject Icon_New;

	public DxxText Text_New;

	public Animator animator;

	protected new void Awake()
	{
	}

	public void init(VIPItemData data, int level)
	{
	}
}
