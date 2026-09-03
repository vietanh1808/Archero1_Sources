using System.Collections.Generic;

namespace ThinkingSDK.PC.Storage
{
	public class ThinkingSDKFileJson
	{
		internal static int EnqueueTrackingData(Dictionary<string, object> data)
		{
			return 0;
		}

		internal static int EventAutoIncrementingID()
		{
			return 0;
		}

		private static void IncreaseTrackingDataID()
		{
		}

		internal static int EventIndexID()
		{
			return 0;
		}

		private static void SaveEventIndexID(int indexID)
		{
		}

		internal static List<Dictionary<string, object>> DequeueBatchTrackingData(int batchSize)
		{
			return null;
		}

		internal static int DeleteBatchTrackingData(int batchSize)
		{
			return 0;
		}

		internal static int DeleteAllTrackingData()
		{
			return 0;
		}
	}
}
