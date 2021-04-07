

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem.ConvertJsonStringToObject
*/
namespace BlueBack.JsonItem.ConvertJsonStringToObject
{
	/** Json文字列 ==> 浮動小数。
	*/
	public class FloatingNumber
	{
		/** Convert
		*/
		public static void Convert(string a_in_jsonstring,out System.Single a_out_value)
		{
			{
				if(a_in_jsonstring.Length < 1){
					//不明。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					a_out_value = default;
					return;
				}

				string t_value;
				if((a_in_jsonstring[a_in_jsonstring.Length - 1] == 'f')||(a_in_jsonstring[a_in_jsonstring.Length - 1] == 'F')){
					t_value = a_in_jsonstring.Substring(0,a_in_jsonstring.Length - 1);
				}else{
					t_value = a_in_jsonstring;
				}

				System.Globalization.NumberStyles t_style = System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowDecimalPoint;
				if(System.Single.TryParse(t_value,t_style,Config.CULTURE,out a_out_value) == true){
					return;
				}
			}

			//不明。

			#if(DEF_BLUEBACK_JSONITEM_ASSERT)
			DebugTool.Assert(false);
			#endif

			a_out_value = default;
			return;
		}

		/** Convert
		*/
		public static void Convert(string a_in_jsonstring,out System.Double a_out_value)
		{
			{
				if(a_in_jsonstring.Length < 1){
					//不明。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					a_out_value = default;
					return;
				}

				string t_value;
				if((a_in_jsonstring[a_in_jsonstring.Length - 1] == 'f')||(a_in_jsonstring[a_in_jsonstring.Length - 1] == 'F')){
					t_value = a_in_jsonstring.Substring(0,a_in_jsonstring.Length - 1);
				}else{
					t_value = a_in_jsonstring;
				}

				System.Globalization.NumberStyles t_style = System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowDecimalPoint;
				if(System.Double.TryParse(t_value,t_style,Config.CULTURE,out a_out_value) == true){
					return;
				}
			}

			//不明。

			#if(DEF_BLUEBACK_JSONITEM_ASSERT)
			DebugTool.Assert(false);
			#endif

			a_out_value = default;
			return;
		}

	}
}

