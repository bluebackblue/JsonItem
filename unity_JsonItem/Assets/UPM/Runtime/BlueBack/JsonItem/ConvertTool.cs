

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief リフレクションツール。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** ConvertTool
	*/
	public class ConvertTool
	{
		/** メンバーリスト。取得。

			継承元を含む。

		*/
		public static void GetMemberListAll(System.Type a_type,System.Collections.Generic.List<System.Reflection.FieldInfo> a_out_list)
		{
			{
				System.Type t_type = a_type;
				while(true){

					//終端チェック。
					if(t_type == null){
						break;
					}else if(t_type == typeof(System.Object)){
						break;
					}else if(t_type == typeof(UnityEngine.Object)){
						break;
					}

					//メンバーリスト。
					System.Reflection.MemberInfo[] t_memberinfo_list = ReflectionTool.ReflectionTool.GetMemberList(t_type);
					foreach(System.Reflection.MemberInfo t_memberinfo in t_memberinfo_list){
						if(t_memberinfo.MemberType == System.Reflection.MemberTypes.Field){
							System.Reflection.FieldInfo t_fieldinfo = t_memberinfo as System.Reflection.FieldInfo;
							if(t_fieldinfo != null){

								//オブジェクト化しない。Json文字列化しない。
								if(t_fieldinfo.IsDefined(typeof(Ignore),false) == true){
									continue;
								}

								//オブジェクト化しない。Json文字列化しない。
								System.Type t_field_type = t_fieldinfo.FieldType;
								if((t_field_type == typeof(System.IntPtr))||(t_field_type == typeof(System.UIntPtr))){
									continue;
								}

								a_out_list.Add(t_fieldinfo);
							}
						}
					}

					//次の継承元へ。
					t_type = t_type.BaseType;
				}
			}
		}

		/** 関数呼び出し用のMethodInfoを取得する。

			System.Collections.Generic.Stack<TYPE>.Push(TYPE);

		*/
		public static System.Reflection.MethodInfo GetMethod_Stack_Push(System.Type a_type,System.Type a_value_type)
		{
			System.Reflection.MethodInfo t_methodinfo = null;

			{
				t_methodinfo = ReflectionTool.ReflectionTool.FindMethodAllParam1(a_type,"Push",a_value_type);

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(t_methodinfo != null);
				#endif
			}

			return t_methodinfo;
		}

		/** 関数呼び出し用のMethodInfoを取得する。

			System.Collections.Generic.LinkedList<TYPE>.AddLast(TYPE);

		*/
		public static System.Reflection.MethodInfo GetMethod_LinkedList_AddLast(System.Type a_type,System.Type a_value_type)
		{
			System.Reflection.MethodInfo t_methodinfo = null;

			{
				t_methodinfo = ReflectionTool.ReflectionTool.FindMethodAllParam1(a_type,"AddLast",a_value_type);

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(t_methodinfo != null);
				#endif
			}

			return t_methodinfo;
		}

		/** 関数呼び出し用のMethodInfoを取得する。

			System.Collections.Generic.HashSet<TYPE>.Add(TYPE);

		*/
		public static System.Reflection.MethodInfo GetMethod_HashSet_Add(System.Type a_type,System.Type a_value_type)
		{
			System.Reflection.MethodInfo t_methodinfo = null;

			{
				t_methodinfo = ReflectionTool.ReflectionTool.FindMethodAllParam1(a_type,"Add",a_value_type);

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(t_methodinfo != null);
				#endif
			}

			return t_methodinfo;
		}

		/** 関数呼び出し用のMethodInfoを取得する。

			System.Collections.Generic.Queue<TYPE>.Enqueue(TYPE);

		*/
		public static System.Reflection.MethodInfo GetMethod_Queue_Enqueue(System.Type a_type,System.Type a_value_type)
		{
			System.Reflection.MethodInfo t_methodinfo = null;

			{
				t_methodinfo = ReflectionTool.ReflectionTool.FindMethodAllParam1(a_type,"Enqueue",a_value_type);

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(t_methodinfo != null);
				#endif
			}

			return t_methodinfo;
		}

		/** 関数呼び出し用のMethodInfoを取得する。

			System.Collections.Generic.SortedSet<TYPE>.Add(TYP));

		*/
		public static System.Reflection.MethodInfo GetMethod_SortedSet_Add(System.Type a_type,System.Type a_value_type)
		{
			System.Reflection.MethodInfo t_methodinfo = null;

			{
				t_methodinfo = ReflectionTool.ReflectionTool.FindMethodAllParam1(a_type,"Add",a_value_type);

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(t_methodinfo != null);
				#endif
			}

			return t_methodinfo;
		}
	}
}

