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

public class RemoteSystemIndex : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RemoteSystemIndex(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RemoteSystemIndex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RemoteSystemIndex() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RemoteSystemIndex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint index {
    set {
      RakNetPINVOKE.RemoteSystemIndex_index_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.RemoteSystemIndex_index_get(swigCPtr);
      return ret;
    } 
  }

  public RemoteSystemIndex next {
    set {
      RakNetPINVOKE.RemoteSystemIndex_next_set(swigCPtr, RemoteSystemIndex.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = RakNetPINVOKE.RemoteSystemIndex_next_get(swigCPtr);
      RemoteSystemIndex ret = (cPtr == global::System.IntPtr.Zero) ? null : new RemoteSystemIndex(cPtr, false);
      return ret;
    } 
  }

  public RemoteSystemIndex() : this(RakNetPINVOKE.new_RemoteSystemIndex(), true) {
  }

}

}
