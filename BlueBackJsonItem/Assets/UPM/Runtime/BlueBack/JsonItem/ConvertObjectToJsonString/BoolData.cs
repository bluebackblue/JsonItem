

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** 真偽データ ==> Json文字列。
	*/
	public static class BoolData
	{
		/** Convert
		*/
		public static void Convert(bool a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			if(a_in_value == true){
				a_out_stringbuilder.Append("true");
			}else{
				a_out_stringbuilder.Append("false");
			}
		}
	}
}

