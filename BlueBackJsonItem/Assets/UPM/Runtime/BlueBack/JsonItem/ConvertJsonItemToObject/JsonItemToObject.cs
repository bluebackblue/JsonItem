

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief オブジェクト化。
*/


/** BlueBack.JsonItem.ConvertJsonItemToObject
*/
namespace BlueBack.JsonItem.ConvertJsonItemToObject
{
	/** ConvertJsonItemToObject
	*/
	public static class ConvertJsonItemToObject
	{
		/** Convert
		*/
		public static void Convert(ref System.Object a_to_refobject,System.Type a_to_type,JsonItem a_from_jsonitem,WorkPool a_workpool)
		{
			WorkPool t_workpool = a_workpool;

			if(t_workpool == null){
				t_workpool = new WorkPool();
			}

			{
				switch(a_from_jsonitem.GetValueType()){
				case ValueType.StringData:
					{
						FromStringData.Convert(ref a_to_refobject,a_to_type,a_from_jsonitem);
					}break;
				case ValueType.SignedNumber:
				case ValueType.UnsignedNumber:
				case ValueType.FloatingNumber:
				case ValueType.DecimalNumber:
				case ValueType.BoolData:
					{
						FromNumber.Convert(ref a_to_refobject,a_to_type,a_from_jsonitem);
					}break;
				case ValueType.IndexArray:
					{
						FromIndexArray.Convert(ref a_to_refobject,a_to_type,a_from_jsonitem,t_workpool);
					}break;
				case ValueType.AssociativeArray:
					{
						FromAssociativeArray.Convert(ref a_to_refobject,a_to_type,a_from_jsonitem,t_workpool);
					}break;
				case ValueType.Null:
					{
						//NULL処理。
					}break;
				default:
					{
						#if(DEF_BLUEBACK_JSONITEM_ASSERT)
						DebugTool.Assert(false);
						#endif
					}break;
				}
			}

			if(a_workpool == null){
				t_workpool.Main();
			}
		}
	}
}

