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

public class NatTypeDetectionServer : PluginInterface2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NatTypeDetectionServer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.NatTypeDetectionServer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NatTypeDetectionServer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NatTypeDetectionServer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_NatTypeDetectionServer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static NatTypeDetectionServer GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.NatTypeDetectionServer_GetInstance();
    NatTypeDetectionServer ret = (cPtr == global::System.IntPtr.Zero) ? null : new NatTypeDetectionServer(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(NatTypeDetectionServer i) {
    RakNetPINVOKE.NatTypeDetectionServer_DestroyInstance(NatTypeDetectionServer.getCPtr(i));
  }

  public NatTypeDetectionServer() : this(RakNetPINVOKE.new_NatTypeDetectionServer(), true) {
  }

  public void Startup(string nonRakNetIP2, string nonRakNetIP3, string nonRakNetIP4) {
    RakNetPINVOKE.NatTypeDetectionServer_Startup(swigCPtr, nonRakNetIP2, nonRakNetIP3, nonRakNetIP4);
  }

  public void Shutdown() {
    RakNetPINVOKE.NatTypeDetectionServer_Shutdown(swigCPtr);
  }

  public class NATDetectionAttempt : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal NATDetectionAttempt(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NATDetectionAttempt obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~NATDetectionAttempt() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_NatTypeDetectionServer_NATDetectionAttempt(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public SystemAddress systemAddress {
      set {
        RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_systemAddress_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_systemAddress_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public NatTypeDetectionServer.NATDetectionState detectionState {
      set {
        RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_detectionState_set(swigCPtr, (int)value);
      } 
      get {
        NatTypeDetectionServer.NATDetectionState ret = (NatTypeDetectionServer.NATDetectionState)RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_detectionState_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint nextStateTime {
      set {
        RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_nextStateTime_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_nextStateTime_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint timeBetweenAttempts {
      set {
        RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_timeBetweenAttempts_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_timeBetweenAttempts_get(swigCPtr);
        return ret;
      } 
    }
  
    public ushort c2Port {
      set {
        RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_c2Port_set(swigCPtr, value);
      } 
      get {
        ushort ret = RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_c2Port_get(swigCPtr);
        return ret;
      } 
    }
  
    public RakNetGUID guid {
      set {
        RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_guid_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatTypeDetectionServer_NATDetectionAttempt_guid_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
    public NATDetectionAttempt() : this(RakNetPINVOKE.new_NatTypeDetectionServer_NATDetectionAttempt(), true) {
    }
  
  }

  public virtual void OnRNS2Recv(SWIGTYPE_p_RNS2RecvStruct recvStruct) {
    RakNetPINVOKE.NatTypeDetectionServer_OnRNS2Recv(swigCPtr, SWIGTYPE_p_RNS2RecvStruct.getCPtr(recvStruct));
  }

  public virtual void DeallocRNS2RecvStruct(SWIGTYPE_p_RNS2RecvStruct s, string file, uint line) {
    RakNetPINVOKE.NatTypeDetectionServer_DeallocRNS2RecvStruct(swigCPtr, SWIGTYPE_p_RNS2RecvStruct.getCPtr(s), file, line);
  }

  public virtual SWIGTYPE_p_RNS2RecvStruct AllocRNS2RecvStruct(string file, uint line) {
    global::System.IntPtr cPtr = RakNetPINVOKE.NatTypeDetectionServer_AllocRNS2RecvStruct(swigCPtr, file, line);
    SWIGTYPE_p_RNS2RecvStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_RNS2RecvStruct(cPtr, false);
    return ret;
  }

  public enum NATDetectionState {
    STATE_NONE,
    STATE_TESTING_NONE_1,
    STATE_TESTING_NONE_2,
    STATE_TESTING_FULL_CONE_1,
    STATE_TESTING_FULL_CONE_2,
    STATE_TESTING_ADDRESS_RESTRICTED_1,
    STATE_TESTING_ADDRESS_RESTRICTED_2,
    STATE_TESTING_PORT_RESTRICTED_1,
    STATE_TESTING_PORT_RESTRICTED_2,
    STATE_DONE
  }

}

}
