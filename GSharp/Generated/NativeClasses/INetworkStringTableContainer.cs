//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSharp.Generated.NativeClasses {
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System;
    
    
    public interface INetworkStringTableContainer {
        
        void dtorINetworkStringTableContainer();
        
        /// <param name='tableName'></param>
        /// <param name='maxentries'></param>
        /// <param name='userdatafixedsize'>Default: 0</param>
        /// <param name='userdatanetworkbits'>Default: 0</param>
        System.IntPtr CreateStringTable(string tableName, int maxentries, [OptionalAttribute()] [DefaultValueAttribute(0)] int userdatafixedsize, [OptionalAttribute()] [DefaultValueAttribute(0)] int userdatanetworkbits);
        
        void RemoveAllTables();
        
        /// <param name='tableName'></param>
        System.IntPtr FindTable(string tableName);
        
        /// <param name='stringTable'></param>
        System.IntPtr GetTable(int stringTable);
        
        int GetNumTables();
        
        /// <param name='tableName'></param>
        /// <param name='maxentries'></param>
        /// <param name='userdatafixedsize'>Default: 0</param>
        /// <param name='userdatanetworkbits'>Default: 0</param>
        /// <param name='bIsFilenames'>Default: false</param>
        System.IntPtr CreateStringTableEx(string tableName, int maxentries, [OptionalAttribute()] [DefaultValueAttribute(0)] int userdatafixedsize, [OptionalAttribute()] [DefaultValueAttribute(0)] int userdatanetworkbits, [OptionalAttribute()] [DefaultValueAttribute(false)] bool bIsFilenames);
        
        /// <param name='table'></param>
        /// <param name='bAllowClientSideAddString'></param>
        void SetAllowClientSideAddString(System.IntPtr table, bool bAllowClientSideAddString);
    }
}
