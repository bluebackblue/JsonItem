

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief デバッグツール。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** DebugTool
	*/
	public class DebugTool
	{
		/** Assert
		*/
		#if(DEF_BLUEBACK_JSONITEM_ASSERT)
		public static void Assert(bool a_flag,System.Exception a_exception = null)
		{
			if(a_flag != true){
				Config.ERRORPROC(a_exception);
			}
		}
		#endif
	}
}

