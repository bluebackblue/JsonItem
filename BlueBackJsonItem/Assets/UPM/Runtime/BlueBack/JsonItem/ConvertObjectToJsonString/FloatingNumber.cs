

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonString
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonString
{
	/** 浮動小数 ==> Json文字列。
	*/
	public static class FloatingNumber
	{
		/** Convert
		*/
		public static void Convert(System.Single a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			#if(DEF_BLUEBACK_ASSERT)
			{
				DebugTool.Assert((System.Single.IsNaN(a_in_value)|System.Single.IsInfinity(a_in_value)) == false); 
			}
			#endif

			string t_string = string.Format(Config.CULTURE,Config.FLOATING_TO_STRING_FORMAT,a_in_value);
			a_out_stringbuilder.Append(t_string);

			if((a_option & ConvertToJsonStringOption.NoFloatingNumberSuffix) == 0){
				a_out_stringbuilder.Append("f");
			}
		}

		/** Create
		*/
		public static void Convert(System.Double a_in_value,System.Text.StringBuilder a_out_stringbuilder,ConvertToJsonStringOption a_option)
		{
			#if(DEF_BLUEBACK_ASSERT)
			{
				DebugTool.Assert((System.Double.IsNaN(a_in_value)|System.Double.IsInfinity(a_in_value)) == false); 
			}
			#endif

			string t_string = string.Format(Config.CULTURE,Config.FLOATING_TO_STRING_FORMAT,a_in_value);
			a_out_stringbuilder.Append(t_string);

			if((a_option & ConvertToJsonStringOption.NoFloatingNumberSuffix) == 0){
				a_out_stringbuilder.Append("f");
			}
		}
	}
}

