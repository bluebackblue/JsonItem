

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertJsonStringToObject
*/
namespace BlueBack.JsonItem.ConvertJsonStringToObject
{
	/** Json文字列 ==> 符号なし整数。
	*/
	public static class UnsignedNumber
	{
		/** Convert
		*/
		public static void Convert(string a_in_jsonstring,out System.UInt64 a_out_value)
		{
			{
				if(a_in_jsonstring.Length < 1){
					//不明。

					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false);
					#endif

					a_out_value = default;
					return;
				}

				string t_value;
				if((a_in_jsonstring[a_in_jsonstring.Length - 1] == 'l')||(a_in_jsonstring[a_in_jsonstring.Length - 1] == 'L')){
					t_value = a_in_jsonstring.Substring(0,a_in_jsonstring.Length - 1);
				}else{
					t_value = a_in_jsonstring;
				}

				System.Globalization.NumberStyles t_style = System.Globalization.NumberStyles.None;
				if(System.UInt64.TryParse(t_value,t_style,Config.CULTURE,out a_out_value) == true){
					return;
				}
			}

			//不明。

			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(false);
			#endif

			a_out_value = default;
			return;
		}

		/** Convert
		*/
		public static void Convert(string a_in_jsonstring,out System.UInt32 a_out_value)
		{
			{
				if(a_in_jsonstring.Length < 1){
					//不明。

					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false);
					#endif

					a_out_value = default;
					return;
				}

				string t_value;
				if((a_in_jsonstring[a_in_jsonstring.Length - 1] == 'l')||(a_in_jsonstring[a_in_jsonstring.Length - 1] == 'L')){
					t_value = a_in_jsonstring.Substring(0,a_in_jsonstring.Length - 1);
				}else{
					t_value = a_in_jsonstring;
				}

				System.Globalization.NumberStyles t_style = System.Globalization.NumberStyles.None;
				if(System.UInt32.TryParse(a_in_jsonstring,t_style,Config.CULTURE,out a_out_value) == true){
					return;
				}
			}

			//不明。

			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(false);
			#endif

			a_out_value = default;
			return;
		}
	}
}

