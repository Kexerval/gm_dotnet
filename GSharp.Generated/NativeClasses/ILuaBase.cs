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
    
    
    public interface ILuaBase {
        
        int Top();
        
        /// <param name='iStackPos'></param>
        void Push(int iStackPos);
        
        /// <param name='iAmt'></param>
        void Pop(int iAmt);
        
        /// <param name='iStackPos'></param>
        void GetTable(int iStackPos);
        
        /// <param name='iStackPos'></param>
        /// <param name='strName'></param>
        void GetField(int iStackPos, string strName);
        
        /// <param name='iStackPos'></param>
        /// <param name='strName'></param>
        void SetField(int iStackPos, string strName);
        
        void CreateTable();
        
        /// <param name='iStackPos'></param>
        void SetTable(int iStackPos);
        
        /// <param name='iStackPos'></param>
        void SetMetaTable(int iStackPos);
        
        /// <param name='i'></param>
        bool GetMetaTable(int i);
        
        /// <param name='iArgs'></param>
        /// <param name='iResults'></param>
        void Call(int iArgs, int iResults);
        
        /// <param name='iArgs'></param>
        /// <param name='iResults'></param>
        /// <param name='iErrorFunc'></param>
        int PCall(int iArgs, int iResults, int iErrorFunc);
        
        /// <param name='iA'></param>
        /// <param name='iB'></param>
        int Equal(int iA, int iB);
        
        /// <param name='iA'></param>
        /// <param name='iB'></param>
        int RawEqual(int iA, int iB);
        
        /// <param name='iStackPos'></param>
        void Insert(int iStackPos);
        
        /// <param name='iStackPos'></param>
        void Remove(int iStackPos);
        
        /// <param name='iStackPos'></param>
        int Next(int iStackPos);
        
        /// <param name='iSize'></param>
        System.IntPtr NewUserdata(uint iSize);
        
        /// <param name='strError'></param>
        void ThrowError(string strError);
        
        /// <param name='iStackPos'></param>
        /// <param name='iType'></param>
        void CheckType(int iStackPos, int iType);
        
        /// <param name='iArgNum'></param>
        /// <param name='strMessage'></param>
        void ArgError(int iArgNum, string strMessage);
        
        /// <param name='iStackPos'></param>
        void RawGet(int iStackPos);
        
        /// <param name='iStackPos'></param>
        void RawSet(int iStackPos);
        
        /// <param name='iStackPos'></param>
        /// <param name='iOutLen'></param>
        string GetString(int iStackPos, System.IntPtr iOutLen);
        
        /// <param name='iStackPos'></param>
        double GetNumber(int iStackPos);
        
        /// <param name='iStackPos'></param>
        bool GetBool(int iStackPos);
        
        /// <param name='iStackPos'></param>
        System.IntPtr GetCFunction(int iStackPos);
        
        /// <param name='iStackPos'></param>
        System.IntPtr GetUserdata(int iStackPos);
        
        void PushNil();
        
        /// <param name='val'></param>
        /// <param name='iLen'></param>
        void PushString(string val, uint iLen);
        
        /// <param name='val'></param>
        void PushNumber(double val);
        
        /// <param name='val'></param>
        void PushBool(bool val);
        
        /// <param name='val'></param>
        void PushCFunction(System.IntPtr val);
        
        /// <param name='val'></param>
        /// <param name='iVars'></param>
        void PushCClosure(System.IntPtr val, int iVars);
        
        /// <param name='param0'></param>
        void PushUserdata(System.IntPtr param0);
        
        int ReferenceCreate();
        
        /// <param name='i'></param>
        void ReferenceFree(int i);
        
        /// <param name='i'></param>
        void ReferencePush(int i);
        
        /// <param name='iType'></param>
        void PushSpecial(int iType);
        
        /// <param name='iStackPos'></param>
        /// <param name='iType'></param>
        bool IsType(int iStackPos, int iType);
        
        /// <param name='iStackPos'></param>
        int GetType(int iStackPos);
        
        /// <param name='iType'></param>
        string GetTypeName(int iType);
        
        /// <param name='strName'></param>
        /// <param name='iType'></param>
        void CreateMetaTableType(string strName, int iType);
        
        /// <param name='iStackPos'></param>
        string CheckString(int iStackPos);
        
        /// <param name='iStackPos'></param>
        double CheckNumber(int iStackPos);
        
        /// <param name='iStackPos'></param>
        int ObjLen(int iStackPos);
        
        /// <param name='iStackPos'></param>
        System.IntPtr GetAngle(int iStackPos);
        
        /// <param name='iStackPos'></param>
        System.IntPtr GetVector(int iStackPos);
        
        /// <param name='val'></param>
        void PushAngle(System.IntPtr val);
        
        /// <param name='val'></param>
        void PushVector(System.IntPtr val);
        
        /// <param name='L'></param>
        void SetState(System.IntPtr L);
        
        /// <param name='strName'></param>
        int CreateMetaTable(string strName);
        
        /// <param name='iType'></param>
        bool PushMetaTable(int iType);
        
        /// <param name='data'></param>
        /// <param name='iType'></param>
        void PushUserType(System.IntPtr data, int iType);
        
        /// <param name='iStackPos'></param>
        /// <param name='data'></param>
        void SetUserType(int iStackPos, System.IntPtr data);
    }
}
