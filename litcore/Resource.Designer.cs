﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace litcore {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("litcore.Resource", typeof(Resource).Assembly);
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
        ///   查找类似 var iframes=document.getElementsByTagName(&quot;iframe&quot;);
        ///var myArray=new Array();
        ///
        ///for(i=0;i&lt;iframes.length;i++){
        ///var litobj={};
        ///litobj.id=iframes[i].id;
        ///litobj.name=iframes[i].name;
        ///litobj.src=iframes[i].src;
        ///myArray.push(litobj);
        ///}
        ///JSON.stringify(myArray); 的本地化字符串。
        /// </summary>
        internal static string getframe {
            get {
                return ResourceManager.GetString("getframe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 var styleElement = document.createElement(&apos;style&apos;);
        ///styleElement.type = &apos;text/css&apos;;
        ///styleElement.id = &apos;styles_js&apos;;
        ///document.getElementsByTagName(&apos;head&apos;)[0].appendChild(styleElement);
        ///styleElement.appendChild(document.createTextNode(&apos;.selectshadow{box-shadow: 0 0 5px #d65c20 inset}&apos;));
        ///
        ///window.litmouse = window.document.body;
        ///litmouse.onmouseover = function(event){
        ///   event.target.classList.add(&quot;selectshadow&quot;)
        ///   window.litmouse = event.target;
        ///};
        ///litmouse.onmouseout = function(event){
        ///    event. [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string hight {
            get {
                return ResourceManager.GetString("hight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //获取xpath，https://www.cnblogs.com/hhmm99/p/11423072.html
        ///window.readXPath=function(element){
        ///    if (element.id !== &quot;&quot;) {//判断id属性，如果这个元素有id，则显 示//*[@id=&quot;xPath&quot;]  形式内容
        ///        return &apos;//*[@id=\&quot;&apos; + element.id + &apos;\&quot;]&apos;;
        ///    }
        ///    //这里需要需要主要字符串转译问题，可参考js 动态生成html时字符串和变量转译（注意引号的作用）
        ///    if (element == document.body) {//递归到body处，结束递归
        ///        return &apos;/html/&apos; + element.tagName.toLowerCase();
        ///    }
        ///    var ix = 1,//在nodelist中的位置，且每次点击初始化
        ///         siblings = element.parentNode.childNodes;//同级的子元素
        /// 
        ///    for [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string readxpath {
            get {
                return ResourceManager.GetString("readxpath", resourceCulture);
            }
        }
    }
}
