

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertJsonStringToObject
*/
namespace BlueBack.JsonItem.ConvertJsonStringToObject
{
	/** Json文字列 ==> １０進数の浮動小数点数。
	*/
	public static class DecimalNumber
	{
		/** Convert
		*/
		public static void Convert(string a_in_jsonstring,out System.Decimal a_out_value)
		{
			{
				if(a_in_jsonstring.Length < 1){
					//不明。

					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",a_in_jsonstring));
					#endif

					a_out_value = default;
					return;
				}

				string t_value;
				if((a_in_jsonstring[a_in_jsonstring.Length - 1] == 'M')||(a_in_jsonstring[a_in_jsonstring.Length - 1] == 'm')){
					t_value = a_in_jsonstring.Substring(0,a_in_jsonstring.Length - 1);
				}else{
					t_value = a_in_jsonstring;
				}

				System.Globalization.NumberStyles t_style = System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowDecimalPoint;
				if(System.Decimal.TryParse(t_value,t_style,Config.CULTURE,out a_out_value) == true){
					return;
				}
			}

			//不明。

			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(false,string.Format("{0}",a_in_jsonstring));
			#endif

			a_out_value = default;
			return;
		}
	}
}

