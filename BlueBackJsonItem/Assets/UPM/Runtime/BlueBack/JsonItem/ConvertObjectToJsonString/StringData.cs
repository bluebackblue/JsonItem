

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** 文字データ ==> Json文字列。
	*/
	public static class StringData
	{
		/** Convert
		*/
		public static void Convert(System.String a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			a_out_stringbuilder.Append("\"");

			{
				if(a_in_value != null){
					for(int ii=0;ii<a_in_value.Length;ii++){
						StringConvertTool.SpecialStringToJsonItemEscapeString.Convert(a_in_value,ii,a_out_stringbuilder);
					}
				}else{

					#if(DEF_BLUEBACK_ASSERT)
					DebugTool.Assert(false);
					#endif

				}
			}

			a_out_stringbuilder.Append( "\"");
			return;
		}
	}
}

