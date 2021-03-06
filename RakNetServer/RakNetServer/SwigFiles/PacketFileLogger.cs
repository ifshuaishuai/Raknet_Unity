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

public class PacketFileLogger : PacketLogger {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PacketFileLogger(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.PacketFileLogger_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PacketFileLogger obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PacketFileLogger() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_PacketFileLogger(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PacketFileLogger() : this(RakNetPINVOKE.new_PacketFileLogger(), true) {
  }

  public void StartLog(string filenamePrefix) {
    RakNetPINVOKE.PacketFileLogger_StartLog(swigCPtr, filenamePrefix);
  }

  public override void WriteLog(string str) {
    RakNetPINVOKE.PacketFileLogger_WriteLog(swigCPtr, str);
  }

}

}
