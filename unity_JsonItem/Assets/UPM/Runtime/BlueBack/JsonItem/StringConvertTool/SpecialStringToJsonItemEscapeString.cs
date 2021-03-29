

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 文字コンバート。
*/


/** BlueBack.JsonItem.StringConvertTool
*/
namespace BlueBack.JsonItem.StringConvertTool
{
	/** 特殊文字 ==> JsonItem用エスケープ文字列。

		"\n" ==> "\\n"

	*/
	public class SpecialStringToJsonItemEscapeString
	{
		/** Convert
		*/
		public static void Convert(string a_string,int a_offset,System.Text.StringBuilder a_stringbuilder)
		{
			switch(a_string[a_offset]){
			case '\0':
				{
					a_stringbuilder.Append("\\0");
				}break;
			case '\n':
				{
					a_stringbuilder.Append("\\n");
				}break;
			case '\"':
				{
					a_stringbuilder.Append("\\\"");
				}break;
			case '\'':
				{
					a_stringbuilder.Append("\\\'");
				}break;
			case '\\':
				{
					a_stringbuilder.Append("\\\\");
				}break;
			default:
				{
					a_stringbuilder.Append(a_string[a_offset]);
				}break;
			}
		}
	}
}

