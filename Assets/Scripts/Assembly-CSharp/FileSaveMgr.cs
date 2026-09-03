using System.Collections.Generic;
using Dxx.Util;

public class FileSaveMgr : CInstance<FileSaveMgr>
{
	public class WriteData
	{
		public string filename;

		public string value;

		public object locker;
	}

	private Dictionary<LocalSave.EThreadWriteType, LocalSaveBase> localSaveDic;

	private float LocalSaveInterval;

	private SequencePool mSeqPool;

	public void RegisterSave(LocalSave.EThreadWriteType type, LocalSaveBase data)
	{
	}

	private void onUpdate()
	{
	}
}
