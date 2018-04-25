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

public class DirectoryDeltaTransfer : PluginInterface2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DirectoryDeltaTransfer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.DirectoryDeltaTransfer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DirectoryDeltaTransfer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DirectoryDeltaTransfer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_DirectoryDeltaTransfer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static DirectoryDeltaTransfer GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.DirectoryDeltaTransfer_GetInstance();
    DirectoryDeltaTransfer ret = (cPtr == global::System.IntPtr.Zero) ? null : new DirectoryDeltaTransfer(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(DirectoryDeltaTransfer i) {
    RakNetPINVOKE.DirectoryDeltaTransfer_DestroyInstance(DirectoryDeltaTransfer.getCPtr(i));
  }

  public DirectoryDeltaTransfer() : this(RakNetPINVOKE.new_DirectoryDeltaTransfer(), true) {
  }

  public void SetFileListTransferPlugin(FileListTransfer flt) {
    RakNetPINVOKE.DirectoryDeltaTransfer_SetFileListTransferPlugin(swigCPtr, FileListTransfer.getCPtr(flt));
  }

  public void SetApplicationDirectory(string pathToApplication) {
    RakNetPINVOKE.DirectoryDeltaTransfer_SetApplicationDirectory(swigCPtr, pathToApplication);
  }

  public void SetUploadSendParameters(PacketPriority _priority, char _orderingChannel) {
    RakNetPINVOKE.DirectoryDeltaTransfer_SetUploadSendParameters(swigCPtr, (int)_priority, _orderingChannel);
  }

  public void AddUploadsFromSubdirectory(string subdir) {
    RakNetPINVOKE.DirectoryDeltaTransfer_AddUploadsFromSubdirectory(swigCPtr, subdir);
  }

  public ushort DownloadFromSubdirectory(string subdir, string outputSubdir, bool prependAppDirToOutputSubdir, SystemAddress host, FileListTransferCBInterface onFileCallback, PacketPriority _priority, char _orderingChannel, FileListProgress cb) {
    ushort ret = RakNetPINVOKE.DirectoryDeltaTransfer_DownloadFromSubdirectory__SWIG_0(swigCPtr, subdir, outputSubdir, prependAppDirToOutputSubdir, SystemAddress.getCPtr(host), FileListTransferCBInterface.getCPtr(onFileCallback), (int)_priority, _orderingChannel, FileListProgress.getCPtr(cb));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort DownloadFromSubdirectory(FileList localFiles, string subdir, string outputSubdir, bool prependAppDirToOutputSubdir, SystemAddress host, FileListTransferCBInterface onFileCallback, PacketPriority _priority, char _orderingChannel, FileListProgress cb) {
    ushort ret = RakNetPINVOKE.DirectoryDeltaTransfer_DownloadFromSubdirectory__SWIG_1(swigCPtr, FileList.getCPtr(localFiles), subdir, outputSubdir, prependAppDirToOutputSubdir, SystemAddress.getCPtr(host), FileListTransferCBInterface.getCPtr(onFileCallback), (int)_priority, _orderingChannel, FileListProgress.getCPtr(cb));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GenerateHashes(FileList localFiles, string outputSubdir, bool prependAppDirToOutputSubdir) {
    RakNetPINVOKE.DirectoryDeltaTransfer_GenerateHashes(swigCPtr, FileList.getCPtr(localFiles), outputSubdir, prependAppDirToOutputSubdir);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearUploads() {
    RakNetPINVOKE.DirectoryDeltaTransfer_ClearUploads(swigCPtr);
  }

  public uint GetNumberOfFilesForUpload() {
    uint ret = RakNetPINVOKE.DirectoryDeltaTransfer_GetNumberOfFilesForUpload(swigCPtr);
    return ret;
  }

  public void SetDownloadRequestIncrementalReadInterface(IncrementalReadInterface _incrementalReadInterface, uint _chunkSize) {
    RakNetPINVOKE.DirectoryDeltaTransfer_SetDownloadRequestIncrementalReadInterface(swigCPtr, IncrementalReadInterface.getCPtr(_incrementalReadInterface), _chunkSize);
  }

}

}
