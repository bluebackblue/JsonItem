

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 文字コンバート。
*/


/** BlueBack.JsonItem.StringConvertTool
*/
namespace BlueBack.JsonItem.StringConvertTool
{
	/** 特殊文字 ==> JsonItem用エスケープ文字列。

		"\n" ==> "\\n"

	*/
	public static class SpecialStringToJsonItemEscapeString
	{
		/** TABLE

			'\0' : 0x00
			'\n' : 0x0A
			'\"' : 0x22
			'\'' : 0x27
			'\\' : 0x5C

		*/
		private readonly static string[] TABLE = new string[]{
			"\\0",null,"\\\"",null,null,null,"\\\'",null,null,null,"\\n",null,"\\\\",null,null,null,
		};

		/** Convert
		*/
		public static void Convert(string a_string,int a_offset,System.Text.StringBuilder a_stringbuilder)
		{
			char t_char = a_string[a_offset];
			if((t_char == 0x00)||(t_char == 0x0A)||(t_char == 0x22)||(t_char == 0x27)||(t_char == 0x5C)){
				a_stringbuilder.Append(TABLE[t_char & 0x0F]);
			}else{
				a_stringbuilder.Append(t_char);
			}
		}
	}
}

