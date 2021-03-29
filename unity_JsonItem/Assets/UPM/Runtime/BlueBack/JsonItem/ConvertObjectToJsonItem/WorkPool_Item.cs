

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief JsonItem化。
*/


/** BlueBack.JsonItem.ConvertObjectToJsonItem
*/
namespace BlueBack.JsonItem.ConvertObjectToJsonItem
{
	/** WorkPool_Item
	*/
	public class WorkPool_Item
	{
		/** モード。
		*/
		public int mode;

		/** ネスト。
		*/
		public int nest;

		/** コンバート元、インスタンス。

			from_object : フィールドインフォ用の親オブジェクト / リストアイテム。

		*/
		public System.Reflection.FieldInfo from_fieldinfo;
		public System.Object from_parent_object;
		public System.Object from_object;
		public System.Type from_type;
		public ConvertToJsonItemOption from_option;

		/** コンバート先。ＪＳＯＮ。
		*/
		public JsonItem to_jsonitem;
		public int to_index;
		public string to_key_string;
	}
}

