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

using System;
using System.Runtime.InteropServices;
#pragma warning disable 0660

public class uint24_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal uint24_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(uint24_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~uint24_t() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_uint24_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


	public override int GetHashCode()
	{    
		return (int)this.val;
	}

	public static implicit operator uint24_t(uint inUint)
	{
		return new uint24_t(inUint);
	} 


	public static bool operator ==(uint24_t a, uint24_t b)
	{
 	   	// If both are null, or both are same instance, return true.
 		if (System.Object.ReferenceEquals(a, b))
 		{
 	       		return true;
 	   	}

  		// If one is null, but not both, return false.
   	 	if (((object)a == null) || ((object)b == null))
    		{
       		 	return false;
    		}

		    return a.Equals(b);//Equals should be overloaded as well
	}

	public static bool operator !=(uint24_t a, uint24_t b)
	{
   		 return a.OpNotEqual(b);
	}

	public static bool operator < (uint24_t a, uint24_t b)
	{
    		return a.OpLess(b);
	}

	public static bool operator >(uint24_t a, uint24_t b)
	{
		return a.OpGreater(b);
	}

	public static uint24_t operator +(uint24_t a, uint24_t b)
	{
		return a.OpPlus(b);
	}

	public static uint24_t operator ++(uint24_t a)
	{
		return a.OpPlusPlus();
	}

	public static uint24_t operator --(uint24_t a)
	{
		return a.OpMinusMinus();
	}

	public static uint24_t operator *(uint24_t a, uint24_t b)
	{
		return a.OpMultiply(b);
	}

	public static uint24_t operator /(uint24_t a, uint24_t b)
	{
		return a.OpDivide(b);
	}

	public static uint24_t operator -(uint24_t a, uint24_t b)
	{
		return a.OpMinus(b);
	}
//------------

	public static bool operator ==(uint24_t a, uint b)
	{
 	   	// If both are null, or both are same instance, return true.
 		if (System.Object.ReferenceEquals(a, b))
 		{
 	       		return true;
 	   	}

  		// If one is null, but not both, return false.
   	 	if (((object)a == null) || ((object)b == null))
    		{
       		 	return false;
    		}

		    return a.Equals(b);//Equals should be overloaded as well
	}

	public static bool operator !=(uint24_t a, uint b)
	{
   		 return a.OpNotEqual(b);
	}

	public static bool operator < (uint24_t a, uint b)
	{
    		return a.OpLess(b);
	}

	public static bool operator >(uint24_t a, uint b)
	{
		return a.OpGreater(b);
	}

	public static uint24_t operator +(uint24_t a, uint b)
	{
		return a.OpPlus(b);
	}

	public static uint24_t operator *(uint24_t a, uint b)
	{
		return a.OpMultiply(b);
	}

	public static uint24_t operator /(uint24_t a, uint b)
	{
		return a.OpDivide(b);
	}

	public static uint24_t operator -(uint24_t a, uint b)
	{
		return a.OpMinus(b);
	}

	public override string ToString()
	{
		return val.ToString();
	}


  public uint val {
    set {
      RakNetPINVOKE.uint24_t_val_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.uint24_t_val_get(swigCPtr);
      return ret;
    } 
  }

  public uint24_t() : this(RakNetPINVOKE.new_uint24_t__SWIG_0(), true) {
  }

  public uint24_t(uint24_t a) : this(RakNetPINVOKE.new_uint24_t__SWIG_1(uint24_t.getCPtr(a)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint24_t OpPlusPlus() {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpPlusPlus(swigCPtr), true);
    return ret;
  }

  private uint24_t OpMinusMinus() {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpMinusMinus(swigCPtr), true);
    return ret;
  }

  public uint24_t CopyData(uint24_t a) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_CopyData__SWIG_0(swigCPtr, uint24_t.getCPtr(a)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(uint24_t right) {
    bool ret = RakNetPINVOKE.uint24_t_Equals__SWIG_0(swigCPtr, uint24_t.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpNotEqual(uint24_t right) {
    bool ret = RakNetPINVOKE.uint24_t_OpNotEqual__SWIG_0(swigCPtr, uint24_t.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpGreater(uint24_t right) {
    bool ret = RakNetPINVOKE.uint24_t_OpGreater__SWIG_0(swigCPtr, uint24_t.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpLess(uint24_t right) {
    bool ret = RakNetPINVOKE.uint24_t_OpLess__SWIG_0(swigCPtr, uint24_t.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint24_t OpPlus(uint24_t other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpPlus__SWIG_0(swigCPtr, uint24_t.getCPtr(other)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint24_t OpMinus(uint24_t other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpMinus__SWIG_0(swigCPtr, uint24_t.getCPtr(other)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint24_t OpDivide(uint24_t other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpDivide__SWIG_0(swigCPtr, uint24_t.getCPtr(other)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint24_t OpMultiply(uint24_t other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpMultiply__SWIG_0(swigCPtr, uint24_t.getCPtr(other)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint24_t(uint a) : this(RakNetPINVOKE.new_uint24_t__SWIG_2(a), true) {
  }

  public uint24_t CopyData(uint a) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_CopyData__SWIG_1(swigCPtr, a), false);
    return ret;
  }

  public bool Equals(uint right) {
    bool ret = RakNetPINVOKE.uint24_t_Equals__SWIG_1(swigCPtr, right);
    return ret;
  }

  private bool OpNotEqual(uint right) {
    bool ret = RakNetPINVOKE.uint24_t_OpNotEqual__SWIG_1(swigCPtr, right);
    return ret;
  }

  private bool OpGreater(uint right) {
    bool ret = RakNetPINVOKE.uint24_t_OpGreater__SWIG_1(swigCPtr, right);
    return ret;
  }

  private bool OpLess(uint right) {
    bool ret = RakNetPINVOKE.uint24_t_OpLess__SWIG_1(swigCPtr, right);
    return ret;
  }

  private uint24_t OpPlus(uint other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpPlus__SWIG_1(swigCPtr, other), true);
    return ret;
  }

  private uint24_t OpMinus(uint other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpMinus__SWIG_1(swigCPtr, other), true);
    return ret;
  }

  private uint24_t OpDivide(uint other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpDivide__SWIG_1(swigCPtr, other), true);
    return ret;
  }

  private uint24_t OpMultiply(uint other) {
    uint24_t ret = new uint24_t(RakNetPINVOKE.uint24_t_OpMultiply__SWIG_1(swigCPtr, other), true);
    return ret;
  }

}

}