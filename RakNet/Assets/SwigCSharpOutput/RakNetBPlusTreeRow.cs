//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace RakNet {

public class RakNetBPlusTreeRow : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetBPlusTreeRow(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RakNetBPlusTreeRow obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetBPlusTreeRow() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakNetBPlusTreeRow(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class ReturnAction : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ReturnAction(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ReturnAction obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ReturnAction() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_RakNetBPlusTreeRow_ReturnAction(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public uint key1 {
      set {
        RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_key1_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_key1_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint key2 {
      set {
        RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_key2_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_key2_get(swigCPtr);
        return ret;
      } 
    }
  
    public int action {
      set {
        RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_action_set(swigCPtr, value);
      } 
      get {
        int ret = RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_action_get(swigCPtr);
        return ret;
      } 
    }
  
    public ReturnAction() : this(RakNetPINVOKE.new_RakNetBPlusTreeRow_ReturnAction(), true) {
    }
  
    public static readonly int NO_ACTION = RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_NO_ACTION_get();
    public static readonly int REPLACE_KEY1_WITH_KEY2 = RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_REPLACE_KEY1_WITH_KEY2_get();
    public static readonly int PUSH_KEY_TO_PARENT = RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_PUSH_KEY_TO_PARENT_get();
    public static readonly int SET_BRANCH_KEY = RakNetPINVOKE.RakNetBPlusTreeRow_ReturnAction_SET_BRANCH_KEY_get();
  
  }

  public RakNetBPlusTreeRow() : this(RakNetPINVOKE.new_RakNetBPlusTreeRow(), true) {
  }

  public void SetPoolPageSize(int size) {
    RakNetPINVOKE.RakNetBPlusTreeRow_SetPoolPageSize(swigCPtr, size);
  }

  public bool Insert(uint key, Table.Row data) {
    bool ret = RakNetPINVOKE.RakNetBPlusTreeRow_Insert(swigCPtr, key, Table.Row.getCPtr(data));
    return ret;
  }

  public void Clear() {
    RakNetPINVOKE.RakNetBPlusTreeRow_Clear(swigCPtr);
  }

  public uint Size() {
    uint ret = RakNetPINVOKE.RakNetBPlusTreeRow_Size(swigCPtr);
    return ret;
  }

  public bool IsEmpty() {
    bool ret = RakNetPINVOKE.RakNetBPlusTreeRow_IsEmpty(swigCPtr);
    return ret;
  }

  public RakNetPageRow GetListHead() {
    global::System.IntPtr cPtr = RakNetPINVOKE.RakNetBPlusTreeRow_GetListHead(swigCPtr);
    RakNetPageRow ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetPageRow(cPtr, false);
    return ret;
  }

  public Table.Row GetDataHead() {
    global::System.IntPtr cPtr = RakNetPINVOKE.RakNetBPlusTreeRow_GetDataHead(swigCPtr);
    Table.Row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Row(cPtr, false);
    return ret;
  }

  public void PrintLeaves() {
    RakNetPINVOKE.RakNetBPlusTreeRow_PrintLeaves(swigCPtr);
  }

  public void PrintGraph() {
    RakNetPINVOKE.RakNetBPlusTreeRow_PrintGraph(swigCPtr);
  }

}

}
