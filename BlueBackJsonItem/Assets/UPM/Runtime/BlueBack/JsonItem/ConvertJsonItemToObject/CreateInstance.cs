

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief オブジェクト化。
*/


/** BlueBack.JsonItem.ConvertJsonItemToObject
*/
namespace BlueBack.JsonItem.ConvertJsonItemToObject
{
	/** インスタンス作成。
	*/
	public static class CreateInstance
	{
		/** Create
		*/
		public static void Create(ref System.Object a_to_refobject,System.Type a_to_type,JsonItem a_from_jsonitem)
		{
			#pragma warning disable 0162
			switch(a_to_type.FullName){
			case "System." + nameof(System.Char):
			case "System." + nameof(System.SByte):
			case "System." + nameof(System.Byte):
			case "System." + nameof(System.Int16):
			case "System." + nameof(System.UInt16):
			case "System." + nameof(System.Int32):
			case "System." + nameof(System.UInt32):
			case "System." + nameof(System.Int64):
			case "System." + nameof(System.UInt64):
			case "System." + nameof(System.Single):
			case "System." + nameof(System.Double):
			case "System." + nameof(System.Boolean):
			case "System." + nameof(System.Decimal):
			case "System." + nameof(System.String):
			case "System." + nameof(System.Object):
				{
					return;
				}break;
			default:
				{
					if(a_from_jsonitem.IsNull() == true){
						//NULL処理。
						return;
					}else{
						if(a_to_type.IsArray == true){
							//[]

							int t_list_count = 0;
							if(a_from_jsonitem.IsIndexArray() == true){
								t_list_count = a_from_jsonitem.GetListMax();
							}

							{
								System.Type t_element_type = a_to_type.GetElementType();
								a_to_refobject = System.Array.CreateInstance(t_element_type,t_list_count);
								return;
							}
						}else{
							//インスタンス。
							{
								a_to_refobject = System.Activator.CreateInstance(a_to_type);
								return;
							}
						}
					}

					//失敗。

					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",a_to_type.FullName));
					#endif

					return;
				}break;
			}
			#pragma warning restore
		}
	}
}

