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

public class NatPunchthroughServer : PluginInterface2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NatPunchthroughServer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.NatPunchthroughServer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NatPunchthroughServer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NatPunchthroughServer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_NatPunchthroughServer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static NatPunchthroughServer GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughServer_GetInstance();
    NatPunchthroughServer ret = (cPtr == global::System.IntPtr.Zero) ? null : new NatPunchthroughServer(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(NatPunchthroughServer i) {
    RakNetPINVOKE.NatPunchthroughServer_DestroyInstance(NatPunchthroughServer.getCPtr(i));
  }

  public NatPunchthroughServer() : this(RakNetPINVOKE.new_NatPunchthroughServer(), true) {
  }

  public void SetDebugInterface(NatPunchthroughServerDebugInterface i) {
    RakNetPINVOKE.NatPunchthroughServer_SetDebugInterface(swigCPtr, NatPunchthroughServerDebugInterface.getCPtr(i));
  }

  public class ConnectionAttempt : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ConnectionAttempt(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ConnectionAttempt obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ConnectionAttempt() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_NatPunchthroughServer_ConnectionAttempt(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public ConnectionAttempt() : this(RakNetPINVOKE.new_NatPunchthroughServer_ConnectionAttempt(), true) {
    }
  
    public NatPunchthroughServer.User sender {
      set {
        RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_sender_set(swigCPtr, NatPunchthroughServer.User.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_sender_get(swigCPtr);
        NatPunchthroughServer.User ret = (cPtr == global::System.IntPtr.Zero) ? null : new NatPunchthroughServer.User(cPtr, false);
        return ret;
      } 
    }
  
    public NatPunchthroughServer.User recipient {
      set {
        RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_recipient_set(swigCPtr, NatPunchthroughServer.User.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_recipient_get(swigCPtr);
        NatPunchthroughServer.User ret = (cPtr == global::System.IntPtr.Zero) ? null : new NatPunchthroughServer.User(cPtr, false);
        return ret;
      } 
    }
  
    public ushort sessionId {
      set {
        RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_sessionId_set(swigCPtr, value);
      } 
      get {
        ushort ret = RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_sessionId_get(swigCPtr);
        return ret;
      } 
    }
  
    public ulong startTime {
      set {
        RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_startTime_set(swigCPtr, value);
      } 
      get {
        ulong ret = RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_startTime_get(swigCPtr);
        return ret;
      } 
    }
  
    public int attemptPhase {
      set {
        RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_attemptPhase_set(swigCPtr, value);
      } 
      get {
        int ret = RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_attemptPhase_get(swigCPtr);
        return ret;
      } 
    }
  
    public static readonly int NAT_ATTEMPT_PHASE_NOT_STARTED = RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_NAT_ATTEMPT_PHASE_NOT_STARTED_get();
    public static readonly int NAT_ATTEMPT_PHASE_GETTING_RECENT_PORTS = RakNetPINVOKE.NatPunchthroughServer_ConnectionAttempt_NAT_ATTEMPT_PHASE_GETTING_RECENT_PORTS_get();
  
  }

  public class User : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal User(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(User obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~User() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_NatPunchthroughServer_User(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public RakNetGUID guid {
      set {
        RakNetPINVOKE.NatPunchthroughServer_User_guid_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughServer_User_guid_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
    public SystemAddress systemAddress {
      set {
        RakNetPINVOKE.NatPunchthroughServer_User_systemAddress_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughServer_User_systemAddress_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public ushort mostRecentPort {
      set {
        RakNetPINVOKE.NatPunchthroughServer_User_mostRecentPort_set(swigCPtr, value);
      } 
      get {
        ushort ret = RakNetPINVOKE.NatPunchthroughServer_User_mostRecentPort_get(swigCPtr);
        return ret;
      } 
    }
  
    public bool isReady {
      set {
        RakNetPINVOKE.NatPunchthroughServer_User_isReady_set(swigCPtr, value);
      } 
      get {
        bool ret = RakNetPINVOKE.NatPunchthroughServer_User_isReady_get(swigCPtr);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_DataStructures__OrderedListT_RakNet__RakNetGUID_RakNet__RakNetGUID_t groupPunchthroughRequests {
      set {
        RakNetPINVOKE.NatPunchthroughServer_User_groupPunchthroughRequests_set(swigCPtr, SWIGTYPE_p_DataStructures__OrderedListT_RakNet__RakNetGUID_RakNet__RakNetGUID_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughServer_User_groupPunchthroughRequests_get(swigCPtr);
        SWIGTYPE_p_DataStructures__OrderedListT_RakNet__RakNetGUID_RakNet__RakNetGUID_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_DataStructures__OrderedListT_RakNet__RakNetGUID_RakNet__RakNetGUID_t(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_DataStructures__ListT_RakNet__NatPunchthroughServer__ConnectionAttempt_p_t connectionAttempts {
      set {
        RakNetPINVOKE.NatPunchthroughServer_User_connectionAttempts_set(swigCPtr, SWIGTYPE_p_DataStructures__ListT_RakNet__NatPunchthroughServer__ConnectionAttempt_p_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.NatPunchthroughServer_User_connectionAttempts_get(swigCPtr);
        SWIGTYPE_p_DataStructures__ListT_RakNet__NatPunchthroughServer__ConnectionAttempt_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_DataStructures__ListT_RakNet__NatPunchthroughServer__ConnectionAttempt_p_t(cPtr, false);
        return ret;
      } 
    }
  
    public bool HasConnectionAttemptToUser(NatPunchthroughServer.User user) {
      bool ret = RakNetPINVOKE.NatPunchthroughServer_User_HasConnectionAttemptToUser(swigCPtr, NatPunchthroughServer.User.getCPtr(user));
      return ret;
    }
  
    public void DerefConnectionAttempt(NatPunchthroughServer.ConnectionAttempt ca) {
      RakNetPINVOKE.NatPunchthroughServer_User_DerefConnectionAttempt(swigCPtr, NatPunchthroughServer.ConnectionAttempt.getCPtr(ca));
    }
  
    public void DeleteConnectionAttempt(NatPunchthroughServer.ConnectionAttempt ca) {
      RakNetPINVOKE.NatPunchthroughServer_User_DeleteConnectionAttempt(swigCPtr, NatPunchthroughServer.ConnectionAttempt.getCPtr(ca));
    }
  
    public void LogConnectionAttempts(RakString rs) {
      RakNetPINVOKE.NatPunchthroughServer_User_LogConnectionAttempts(swigCPtr, RakString.getCPtr(rs));
      if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public User() : this(RakNetPINVOKE.new_NatPunchthroughServer_User(), true) {
    }
  
  }

  public ulong lastUpdate {
    set {
      RakNetPINVOKE.NatPunchthroughServer_lastUpdate_set(swigCPtr, value);
    } 
    get {
      ulong ret = RakNetPINVOKE.NatPunchthroughServer_lastUpdate_get(swigCPtr);
      return ret;
    } 
  }

}

}
