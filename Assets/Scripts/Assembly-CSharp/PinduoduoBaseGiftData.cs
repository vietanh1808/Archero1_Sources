using System;
using System.Collections.Generic;

public class PinduoduoBaseGiftData
{
	public int ID;

	public List<ViewCellData> dropDatas;

	public int price;

	public long startTime;

	public long endTime;

	public bool isBuyed;

	public int curNum;

	public bool isLast;

	public Action OnBuyCallBack;

	public virtual bool isOpen => false;

	public long leftSellTime => 0L;

	public PinduoduoBaseGiftData(int id, int _price, long _startTime, long _endTime, int[][] reward, bool _isLast)
	{
	}

	public void SetBuyed()
	{
	}
}
