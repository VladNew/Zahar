﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zahar.SqlClient {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Zahar.SqlClient.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;Catalog&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;xs:element maxOccurs=&quot;unbounded&quot; name=&quot;Schema&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///              &lt;xs:element minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot; name=&quot;Procedure&quot;&gt;
        ///                &lt;xs:complexType&gt;
        ///                  &lt;xs:attribute name=&quot;Name&quot; typ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Catalog {
            get {
                return ResourceManager.GetString("Catalog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT 
        ///	s.[Name],
        ///	(
        ///		SELECT p.[name] AS [Name], QUOTENAME(s.[name]) + &apos;.&apos; + QUOTENAME(p.[name]) AS [FullName]
        ///		FROM sys.procedures AS p
        ///		WHERE p.schema_id = s.schema_id
        ///		AND p.is_ms_shipped = 0
        ///		FOR XML RAW(&apos;Procedure&apos;), TYPE
        ///	)
        ///FROM sys.schemas AS s
        ///WHERE s.[name] NOT IN (
        ///	&apos;db_accessadmin&apos;
        ///	,&apos;db_backupoperator&apos;
        ///	,&apos;db_datareader&apos;
        ///	,&apos;db_datawriter&apos;
        ///	,&apos;db_ddladmin&apos;
        ///	,&apos;db_denydatareader&apos;
        ///	,&apos;db_denydatawriter&apos;
        ///	,&apos;db_owner&apos;
        ///	,&apos;db_securityadmin&apos;
        ///	,&apos;guest&apos;
        ///	,&apos;INFORMATION_SCHEMA&apos;
        ///	,&apos;sy [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CatalogQuery {
            get {
                return ResourceManager.GetString("CatalogQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace Zahar.SqlClient
        ///{
        ///    using System;
        ///
        ///    /// &lt;summary&gt;
        ///    /// &lt;see cref=&quot;System.IDisposable&quot;/&gt; factory.
        ///    /// &lt;/summary&gt;
        ///    public static class Disposable
        ///    {
        ///        public static readonly IDisposable Null = new DisposableNullObject();
        ///
        ///        public static IDisposable Create(Action callback) { return new RelayDisposable(callback); }
        ///
        ///        sealed class DisposableNullObject : IDisposable
        ///        {
        ///            public void Dispose() { }
        ///        }
        ///
        ///        sealed class Rel [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Disposable {
            get {
                return ResourceManager.GetString("Disposable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace Zahar.SqlClient
        ///{
        ///    using System;
        ///
        ///    /// &lt;summary&gt;
        ///    /// &lt;see cref=&quot;System.IDisposable&quot;/&gt; factory.
        ///    /// &lt;/summary&gt;
        ///    public static class Disposable
        ///    {
        ///        public static readonly IDisposable Null = new DisposableNullObject();
        ///
        ///        public static IDisposable Create(Action callback) { return new RelayDisposable(callback); }
        ///
        ///        sealed class DisposableNullObject : IDisposable
        ///        {
        ///            public void Dispose() { }
        ///        }
        ///
        ///        sealed class Rel [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Disposable1 {
            get {
                return ResourceManager.GetString("Disposable1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace Zahar.SqlClient
        ///{
        ///    public struct SqlCommandReturnValue
        ///    {
        ///        readonly System.Data.SqlClient.SqlParameter m_returnValueParameter;
        ///
        ///        /// &lt;summary&gt;
        ///        /// 
        ///        /// &lt;/summary&gt;
        ///        public SqlCommandReturnValue(System.Data.SqlClient.SqlCommand command)
        ///	    {
        ///		    if(ReferenceEquals(command, null))
        ///			    throw new System.ArgumentNullException(nameof(command));
        ///            for (int i = 0; i &lt; command.Parameters.Count; ++i)
        ///            {
        ///                m_re [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReturnValueSqlCommandOutput {
            get {
                return ResourceManager.GetString("ReturnValueSqlCommandOutput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace Zahar.SqlClient
        ///{
        ///    /// &lt;summary&gt;
        ///    /// 
        ///    /// &lt;/summary&gt;
        ///    public class SqlDbClient
        ///    {
        ///        #region Nested Types
        ///        struct SqlCommandState
        ///        {
        ///            readonly System.Data.SqlClient.SqlConnection Connection;
        ///            readonly System.Data.SqlClient.SqlTransaction Transaction;
        ///
        ///            public SqlCommandState(System.Data.SqlClient.SqlCommand command)
        ///            {
        ///                Connection = command.Connection;
        ///                Transaction = comman [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlDbClient {
            get {
                return ResourceManager.GetString("SqlDbClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; 
        ///           xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; 
        ///           targetNamespace=&quot;Zahar.SqlClient.Mapping&quot; 
        ///           xmlns:z=&quot;Zahar.SqlClient.Mapping&quot;&gt;
        ///  &lt;xs:element name=&quot;Mapping&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;xs:element name=&quot;Procedures&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///              &lt;xs:element minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot; nam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Zahar_SqlClient {
            get {
                return ResourceManager.GetString("Zahar_SqlClient", resourceCulture);
            }
        }
    }
}
