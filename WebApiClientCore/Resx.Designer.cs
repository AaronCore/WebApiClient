﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiClientCore {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resx {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resx() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebApiClientCore.Resx", typeof(Resx).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 Content-Type必须保持为{0} 的本地化字符串。
        /// </summary>
        internal static string contenType_RemainAs {
            get {
                return ResourceManager.GetString("contenType_RemainAs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 服务器响应了错误的http状态码：{0} {1} 的本地化字符串。
        /// </summary>
        internal static string failure_StatusCode {
            get {
                return ResourceManager.GetString("failure_StatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 数据内容已经被缓存和固化 的本地化字符串。
        /// </summary>
        internal static string httpContent_isBuffered {
            get {
                return ResourceManager.GetString("httpContent_isBuffered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 UriAttribute必须修饰于第一个参数 的本地化字符串。
        /// </summary>
        internal static string invalid_UriAttribute {
            get {
                return ResourceManager.GetString("invalid_UriAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 类型{0}不存在构造函数.ctor({1}) 的本地化字符串。
        /// </summary>
        internal static string missing_Ctor {
            get {
                return ResourceManager.GetString("missing_Ctor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 重试已经达到了最大次数限制：{0} 的本地化字符串。
        /// </summary>
        internal static string outof_MaxLimited {
            get {
                return ResourceManager.GetString("outof_MaxLimited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无法将参数{0}转换为Timeout 的本地化字符串。
        /// </summary>
        internal static string parameter_CannotCvtTimeout {
            get {
                return ResourceManager.GetString("parameter_CannotCvtTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请传入{0}参数 的本地化字符串。
        /// </summary>
        internal static string parameter_CannotMissing {
            get {
                return ResourceManager.GetString("parameter_CannotMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数{0}必须为HttpContent类型 的本地化字符串。
        /// </summary>
        internal static string parameter_MustbeHttpContenType {
            get {
                return ResourceManager.GetString("parameter_MustbeHttpContenType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数{0}必须置前 的本地化字符串。
        /// </summary>
        internal static string parameter_MustPutForward {
            get {
                return ResourceManager.GetString("parameter_MustPutForward", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}要求为绝对Uri 的本地化字符串。
        /// </summary>
        internal static string required_AbsoluteUri {
            get {
                return ResourceManager.GetString("required_AbsoluteUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未配置HttpHost，接口需要先配置HttpHost 的本地化字符串。
        /// </summary>
        internal static string required_HttpHost {
            get {
                return ResourceManager.GetString("required_HttpHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 类型{0}必须为接口类型 的本地化字符串。
        /// </summary>
        internal static string required_InterfaceType {
            get {
                return ResourceManager.GetString("required_InterfaceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请传入name和value参数 的本地化字符串。
        /// </summary>
        internal static string required_NameAndValue {
            get {
                return ResourceManager.GetString("required_NameAndValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 JsonPatchContent的请求方法要求为PATCH 的本地化字符串。
        /// </summary>
        internal static string required_PatchMethod {
            get {
                return ResourceManager.GetString("required_PatchMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 接口必须为public修饰：{0} 的本地化字符串。
        /// </summary>
        internal static string required_PublicInterface {
            get {
                return ResourceManager.GetString("required_PublicInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 未配置RequestUri，RequestUri不能为null 的本地化字符串。
        /// </summary>
        internal static string required_RequestUri {
            get {
                return ResourceManager.GetString("required_RequestUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Timeout值{0}不能超时HttpClient.Timeout 的本地化字符串。
        /// </summary>
        internal static string timeout_OutOfRange {
            get {
                return ResourceManager.GetString("timeout_OutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 结果不符合预期值 的本地化字符串。
        /// </summary>
        internal static string unexpected_Result {
            get {
                return ResourceManager.GetString("unexpected_Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 接口参数不支持ref/out修饰: {0} 的本地化字符串。
        /// </summary>
        internal static string unsupported_ByRef {
            get {
                return ResourceManager.GetString("unsupported_ByRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持将ContentType为 {0} 的内容转换为{1} 的本地化字符串。
        /// </summary>
        internal static string unsupported_ContentType {
            get {
                return ResourceManager.GetString("unsupported_ContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无法将JsonTokenType.{0}转换为{1}类型 的本地化字符串。
        /// </summary>
        internal static string unsupported_ConvertType {
            get {
                return ResourceManager.GetString("unsupported_ConvertType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持泛型方法: {0} 的本地化字符串。
        /// </summary>
        internal static string unsupported_GenericMethod {
            get {
                return ResourceManager.GetString("unsupported_GenericMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持注册泛型定义类型{0} 的本地化字符串。
        /// </summary>
        internal static string unsupported_GenericTypeDefinitionType {
            get {
                return ResourceManager.GetString("unsupported_GenericTypeDefinitionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}方法不支持使用{1} 的本地化字符串。
        /// </summary>
        internal static string unsupported_HttpContent {
            get {
                return ResourceManager.GetString("unsupported_HttpContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 HttpMessageHandler必须是DelegatingHandler或者HttpClientHandler 的本地化字符串。
        /// </summary>
        internal static string unsupported_HttpMessageHandler {
            get {
                return ResourceManager.GetString("unsupported_HttpMessageHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 HttpClientHandler必须开启UseCookies 的本地化字符串。
        /// </summary>
        internal static string unsupported_NoUseCookies {
            get {
                return ResourceManager.GetString("unsupported_NoUseCookies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持属性访问器: {0} 的本地化字符串。
        /// </summary>
        internal static string unsupported_Property {
            get {
                return ResourceManager.GetString("unsupported_Property", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 返回类型必须为Task、Task&lt;&gt;或ITask&lt;&gt;: {0} 的本地化字符串。
        /// </summary>
        internal static string unsupported_ReturnType {
            get {
                return ResourceManager.GetString("unsupported_ReturnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不支持序列化类型{0}，该类型只能做为方法的参数值 的本地化字符串。
        /// </summary>
        internal static string unsupported_SerializeApiParametern {
            get {
                return ResourceManager.GetString("unsupported_SerializeApiParametern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 由于使用了{0}的请求方法，不支持设置RequestMessage.Content 的本地化字符串。
        /// </summary>
        internal static string unsupported_SetContent {
            get {
                return ResourceManager.GetString("unsupported_SetContent", resourceCulture);
            }
        }
    }
}
