using System.Collections.Generic;
using GameProtocol;

public class TotemSourceData
{
	public List<TotemItemSourceData> SourceData { get; set; }

	public static TotemSourceData Create(List<TotemItemSourceData> sourceData)
	{
		return null;
	}

	public void DelegateTotemDataByRowID(long[] rowID)
	{
	}

	public void AddTotemData(CTotem[] totem)
	{
	}

	public void SyncTotemOneData(TotemItemSourceData data)
	{
	}
}
