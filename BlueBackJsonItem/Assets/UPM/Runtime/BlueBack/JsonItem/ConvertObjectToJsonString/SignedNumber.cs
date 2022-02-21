

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** 符号あり整数 ==> Json文字列。
	*/
	public static class SignedNumber
	{
		/** Convert
		*/
		public static void Convert(System.Int32 a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			string t_string = a_in_value.ToString(Config.CULTURE);
			a_out_stringbuilder.Append(t_string);

			if((a_option & ConvertToJsonStringOption.NoSignedNumberSuffix) == 0){
				a_out_stringbuilder.Append("l");
			}

			return;
		}

		/** Convert
		*/
		public static void Convert(System.Int64 a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			string t_string = a_in_value.ToString(Config.CULTURE);
			a_out_stringbuilder.Append(t_string);

			if((a_option & ConvertToJsonStringOption.NoSignedNumberSuffix) == 0){
				a_out_stringbuilder.Append("l");
			}
		}
	}
}

