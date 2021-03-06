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

public class PunchthroughConfiguration : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PunchthroughConfiguration(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PunchthroughConfiguration obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PunchthroughConfiguration() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_PunchthroughConfiguration(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PunchthroughConfiguration() : this(RakNetPINVOKE.new_PunchthroughConfiguration(), true) {
  }

  public ulong TIME_BETWEEN_PUNCH_ATTEMPTS_INTERNAL {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_TIME_BETWEEN_PUNCH_ATTEMPTS_INTERNAL_set(swigCPtr, value);
    } 
    get {
      ulong ret = RakNetPINVOKE.PunchthroughConfiguration_TIME_BETWEEN_PUNCH_ATTEMPTS_INTERNAL_get(swigCPtr);
      return ret;
    } 
  }

  public ulong TIME_BETWEEN_PUNCH_ATTEMPTS_EXTERNAL {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_TIME_BETWEEN_PUNCH_ATTEMPTS_EXTERNAL_set(swigCPtr, value);
    } 
    get {
      ulong ret = RakNetPINVOKE.PunchthroughConfiguration_TIME_BETWEEN_PUNCH_ATTEMPTS_EXTERNAL_get(swigCPtr);
      return ret;
    } 
  }

  public int UDP_SENDS_PER_PORT_INTERNAL {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_UDP_SENDS_PER_PORT_INTERNAL_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_UDP_SENDS_PER_PORT_INTERNAL_get(swigCPtr);
      return ret;
    } 
  }

  public int UDP_SENDS_PER_PORT_EXTERNAL {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_UDP_SENDS_PER_PORT_EXTERNAL_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_UDP_SENDS_PER_PORT_EXTERNAL_get(swigCPtr);
      return ret;
    } 
  }

  public int INTERNAL_IP_WAIT_AFTER_ATTEMPTS {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_INTERNAL_IP_WAIT_AFTER_ATTEMPTS_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_INTERNAL_IP_WAIT_AFTER_ATTEMPTS_get(swigCPtr);
      return ret;
    } 
  }

  public int MAX_PREDICTIVE_PORT_RANGE {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_MAX_PREDICTIVE_PORT_RANGE_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_MAX_PREDICTIVE_PORT_RANGE_get(swigCPtr);
      return ret;
    } 
  }

  public int EXTERNAL_IP_WAIT_AFTER_FIRST_TTL {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_EXTERNAL_IP_WAIT_AFTER_FIRST_TTL_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_EXTERNAL_IP_WAIT_AFTER_FIRST_TTL_get(swigCPtr);
      return ret;
    } 
  }

  public int EXTERNAL_IP_WAIT_BETWEEN_PORTS {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_EXTERNAL_IP_WAIT_BETWEEN_PORTS_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_EXTERNAL_IP_WAIT_BETWEEN_PORTS_get(swigCPtr);
      return ret;
    } 
  }

  public int EXTERNAL_IP_WAIT_AFTER_ALL_ATTEMPTS {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_EXTERNAL_IP_WAIT_AFTER_ALL_ATTEMPTS_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_EXTERNAL_IP_WAIT_AFTER_ALL_ATTEMPTS_get(swigCPtr);
      return ret;
    } 
  }

  public int MAXIMUM_NUMBER_OF_INTERNAL_IDS_TO_CHECK {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_MAXIMUM_NUMBER_OF_INTERNAL_IDS_TO_CHECK_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.PunchthroughConfiguration_MAXIMUM_NUMBER_OF_INTERNAL_IDS_TO_CHECK_get(swigCPtr);
      return ret;
    } 
  }

  public bool retryOnFailure {
    set {
      RakNetPINVOKE.PunchthroughConfiguration_retryOnFailure_set(swigCPtr, value);
    } 
    get {
      bool ret = RakNetPINVOKE.PunchthroughConfiguration_retryOnFailure_get(swigCPtr);
      return ret;
    } 
  }

}

}
