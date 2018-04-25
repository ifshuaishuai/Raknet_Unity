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

public class NatPunchthroughClient : PluginInterface2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NatPunchthroughClient(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.NatPunchthroughClient_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NatPunchthroughClient obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NatPunchthroughClient() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_NatPunchthroughClient(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static NatPunchthroughClient GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughClient_GetInstance();
    NatPunchthroughClient ret = (cPtr == global::System.IntPtr.Zero) ? null : new NatPunchthroughClient(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(NatPunchthroughClient i) {
    RakNetPINVOKE.NatPunchthroughClient_DestroyInstance(NatPunchthroughClient.getCPtr(i));
  }

  public NatPunchthroughClient() : this(RakNetPINVOKE.new_NatPunchthroughClient(), true) {
  }

  public void FindRouterPortStride(SystemAddress facilitator) {
    RakNetPINVOKE.NatPunchthroughClient_FindRouterPortStride(swigCPtr, SystemAddress.getCPtr(facilitator));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool OpenNAT(RakNetGUID destination, SystemAddress facilitator) {
    bool ret = RakNetPINVOKE.NatPunchthroughClient_OpenNAT(swigCPtr, RakNetGUID.getCPtr(destination), SystemAddress.getCPtr(facilitator));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PunchthroughConfiguration GetPunchthroughConfiguration() {
    global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughClient_GetPunchthroughConfiguration(swigCPtr);
    PunchthroughConfiguration ret = (cPtr == global::System.IntPtr.Zero) ? null : new PunchthroughConfiguration(cPtr, false);
    return ret;
  }

  public void SetDebugInterface(NatPunchthroughDebugInterface i) {
    RakNetPINVOKE.NatPunchthroughClient_SetDebugInterface(swigCPtr, NatPunchthroughDebugInterface.getCPtr(i));
  }

  public void GetUPNPPortMappings(string externalPort, string internalPort, SystemAddress natPunchthroughServerAddress) {
    RakNetPINVOKE.NatPunchthroughClient_GetUPNPPortMappings(swigCPtr, externalPort, internalPort, SystemAddress.getCPtr(natPunchthroughServerAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    RakNetPINVOKE.NatPunchthroughClient_Clear(swigCPtr);
  }

}

}
