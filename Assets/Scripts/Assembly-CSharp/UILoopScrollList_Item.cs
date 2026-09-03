using UnityEngine;

public abstract class UILoopScrollList_Item : MonoBehaviour
{
	protected UILoopScrollList mList;

	public void SetList(UILoopScrollList list)
	{
	}

	public abstract void OnListEnable();

	public abstract void OnCreate();

	public abstract void Refresh(object data, int index);

	public abstract void OnRecycle();

	public abstract void OnScrollEnd();
}
