

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンフィグ。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** Config
	*/
	public static class Config
	{
		/** LOOPLIMIT
		*/
		#if(DEF_BLUEBACK_JSONITEM_LOOPLIMIT)
		public static int LOOPLIMIT = ushort.MaxValue;
		#endif

		/** NESTLIMIT
		*/
		#if(DEF_BLUEBACK_JSONITEM_NESTLIMIT)
		public static int NESTLIMIT = ushort.MaxValue;
		#endif

		/** CULTURE
		*/
		public static System.IFormatProvider CULTURE = System.Globalization.CultureInfo.CreateSpecificCulture("ja-JP");

		/** FLOATING_TO_STRING_FORMAT
		*/
		public static string FLOATING_TO_STRING_FORMAT = "{0:e16}";

		/** FLOATING_SEPARATOR
		*/
		public static char FLOATING_SEPARATOR = '.';

		/** デフォルトオプション。
		*/
		public static ConvertToJsonStringOption DEFAULT_CONVERTTOJSONSTRING_OPTION = ConvertToJsonStringOption.None;

		/** デフォルトオプション。
		*/
		public static ConvertToJsonItemOption DEFAULT_CONVERTTOJSONITEM_OPTION = ConvertToJsonItemOption.None;
	}
}

