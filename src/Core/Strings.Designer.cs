﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FluentMethods {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
#if NetCore
                    var assembly = typeof(Strings).GetTypeInfo().Assembly;
#else
                    var assembly = typeof(Strings).Assembly;
#endif
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FluentMethods.Strings", assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Start index is out of bounds for the array or length is greater than the number of elements from index to the end of the source array. 的本地化字符串。
        /// </summary>
        internal static string ArgumentOutOfRange_ArraySlice {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_ArraySlice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot convert null or empty string to type {0}. 的本地化字符串。
        /// </summary>
        internal static string CannotConvertNullToValueType {
            get {
                return ResourceManager.GetString("CannotConvertNullToValueType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot convert from {0} to type {1} of property {2} for component {3}. 的本地化字符串。
        /// </summary>
        internal static string CannotConvertPropertyValue {
            get {
                return ResourceManager.GetString("CannotConvertPropertyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot convert from {0} to type {1}. 的本地化字符串。
        /// </summary>
        internal static string CannotConvertValue {
            get {
                return ResourceManager.GetString("CannotConvertValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Only single dimension arrays are supported here. 的本地化字符串。
        /// </summary>
        internal static string Rank_MultiDimNotSupported {
            get {
                return ResourceManager.GetString("Rank_MultiDimNotSupported", resourceCulture);
            }
        }
		
		/// <summary>
        ///   查找类似 The value of field &apos;{0}&apos; is null, and cannot be converted to {1}. 的本地化字符串。
        /// </summary>
        internal static string CannotCastNullToValueType {
            get {
                return ResourceManager.GetString("CannotCastNullToValueType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The field &apos;{0}&apos; does not belong to the record. 的本地化字符串。
        /// </summary>
        internal static string FieldCannotBeFound {
            get {
                return ResourceManager.GetString("FieldCannotBeFound", resourceCulture);
            }
        }
        
		/// <summary>
        ///   查找类似 Positive number required. 的本地化字符串。
        /// </summary>
        internal static string ArgumentOutOfRange_NeedPosNum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedPosNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Stream does not support reading. 的本地化字符串。
        /// </summary>
        internal static string NotSupported_UnreadableStream {
            get {
                return ResourceManager.GetString("NotSupported_UnreadableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Stream does not support writing. 的本地化字符串。
        /// </summary>
        internal static string NotSupported_UnwritableStream {
            get {
                return ResourceManager.GetString("NotSupported_UnwritableStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot access a closed Stream. 的本地化字符串。
        /// </summary>
        internal static string ObjectDisposed_StreamClosed {
            get {
                return ResourceManager.GetString("ObjectDisposed_StreamClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The field or property &apos;{0}&apos; cannot be found in the type {1}. 的本地化字符串。
        /// </summary>
        internal static string CannotFindTypeMember {
            get {
                return ResourceManager.GetString("CannotFindTypeMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The value cannot be null or empty. 的本地化字符串。
        /// </summary>
        internal static string CannotNullOrEmpty {
            get {
                return ResourceManager.GetString("CannotNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The order syntax is invalid: {0}. 的本地化字符串。
        /// </summary>
        internal static string InvalidOrderSyntax {
            get {
                return ResourceManager.GetString("InvalidOrderSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Sequence contains more than one matching element 的本地化字符串。
        /// </summary>
        internal static string MoreThanOneMatch {
            get {
                return ResourceManager.GetString("MoreThanOneMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Non negative number is required. 的本地化字符串。
        /// </summary>
        internal static string NeedNonNegNum {
            get {
                return ResourceManager.GetString("NeedNonNegNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Sequence contains no elements 的本地化字符串。
        /// </summary>
        internal static string NoElements {
            get {
                return ResourceManager.GetString("NoElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Sequence contains no matching element 的本地化字符串。
        /// </summary>
        internal static string NoMatch {
            get {
                return ResourceManager.GetString("NoMatch", resourceCulture);
            }
		}
    }
}
