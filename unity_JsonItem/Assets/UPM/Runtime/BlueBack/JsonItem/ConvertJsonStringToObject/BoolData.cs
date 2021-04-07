

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem.ConvertJsonStringToObject
*/
namespace BlueBack.JsonItem.ConvertJsonStringToObject
{
	/** Json文字列 ==> 真偽データ。
	*/
	public class BoolData
	{
		/** Convert
		*/
		public static void Convert(string a_in_jsonstring,out bool a_out_value)
		{
			if(a_in_jsonstring.Length < 1){
				//不明。

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(false);
				#endif

				a_out_value = default;
				return;
			}

			#pragma warning disable 0162
			switch(a_in_jsonstring[0]){
			case 't':
			case 'T':
				{
					a_out_value = true;
					return;
				}break;
			default:
				{
					a_out_value = false;
					return;
				}break;
			}
			#pragma warning restore

		}
	}
}

