

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** １０進数の浮動小数点数 ==> Json文字列。
	*/
	public static class DecimalNumber
	{
		/** Convert
		*/
		public static void Convert(System.Decimal a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			string t_string = a_in_value.ToString(Config.CULTURE);
			a_out_stringbuilder.Append(t_string);

			if((a_option & ConvertToJsonStringOption.NoDecimalNumberSuffix) == 0){
				a_out_stringbuilder.Append("m");
			}
		}
	}
}

