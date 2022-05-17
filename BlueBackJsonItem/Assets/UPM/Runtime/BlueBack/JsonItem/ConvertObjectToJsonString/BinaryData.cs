

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** バイナリデータ ==> Json文字列。
	*/
	public static class BinaryData
	{
		/** Convert
		*/
		public static void Convert(System.Collections.Generic.List<byte> a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			a_out_stringbuilder.Append("<");

			{
				if(a_in_value != null){
					for(int ii=0;ii<a_in_value.Count;ii++){
						a_out_stringbuilder.Append(string.Format("{0:X2}",a_in_value[ii]));
					}
				}else{

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

				}
			}

			a_out_stringbuilder.Append(">");

			return;
		}
	}
}

