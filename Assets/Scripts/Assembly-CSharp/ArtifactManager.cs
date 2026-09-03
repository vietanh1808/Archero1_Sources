using System.Collections.Generic;
using UnityEngine;

public class ArtifactManager : CInstance<ArtifactManager>
{
	private Dictionary<int, ArtifactData> ArtifactDataMap;

	public ArtifactData GetEntityArtifactData(int guid)
	{
		return null;
	}

	protected override void Clear()
	{
	}

	public ArtifactData AddArtifact(int entityGuid, Transform parent, ArtifactRecycleType recycleType)
	{
		return null;
	}

	public void RemoveArtifact(int entityGuid)
	{
	}

	public void RemoveAllArtifact()
	{
	}

	public void SetArtifactItemActive(int entityGuid, Transform parent, ArtifactRecycleType recycleType, ArtifactItemData artifactItemData, ArtifactItemStatus artifactItemStatus, bool needUpdateRotate)
	{
	}

	public ArtifactShowItem ChangeArtifactItemModel(int entityGuid, int artifactID, string modelID)
	{
		return null;
	}

	public void DestroyArtifactItem(int entityGuid, ArtifactItemData artifactItemData)
	{
	}

	public void RemoveArtifactData(int entityGuid)
	{
	}

	public void ShowUIArtifact(int belongEntityGuid, Transform parent)
	{
	}

	public void ShowUIArtifact(int belongEntityGuid, Transform parent, List<LocalSave.ArtifactOne> dataList)
	{
	}

	public void ShowUIArtifact(int belongEntityGuid, Transform parent, LocalSave.ArtifactOne data)
	{
	}

	public void ShowUIArtifact(int belongEntityGuid, Transform parent, List<ArtifactItemData> data)
	{
	}

	public void HideUIArtifact(int belongEntityGuid, Transform parent)
	{
	}

	public void HideUIArtifact(int belongEntityGuid, Transform parent, List<LocalSave.ArtifactOne> dataList)
	{
	}

	public void HideUIArtifact(int belongEntityGuid, Transform parent, LocalSave.ArtifactOne data)
	{
	}

	public void RemoveUIArtifact(int belongEntityGuid)
	{
	}

	public void SetUIArtifactActive(int belongEntityGuid, Transform parent, ArtifactItemData artifactItemData, bool isShow)
	{
	}
}
