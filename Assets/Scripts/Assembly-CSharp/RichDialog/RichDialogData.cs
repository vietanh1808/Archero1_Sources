using System.Collections.Generic;

namespace RichDialog
{
	public class RichDialogData
	{
		public string strTitle;

		public List<IRichDialogData> items;

		public void AddGoto(RichDialogGotoData data)
		{
		}

		public void AddCheckBox(RichDialogCheckBoxData data)
		{
		}

		public void AddText(RichDialogTextData data)
		{
		}

		public void AddSlider(RichDialogSliderData data)
		{
		}

		public void AddInput(RichDialogInputData data)
		{
		}

		public void AddSpace(RichDialogSpaceData data)
		{
		}
	}
}
