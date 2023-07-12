// Copyright Epic Games, Inc. All Rights Reserved.

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FDatasmithFacadeVisibilityAnimation : FDatasmithFacadeBaseAnimation {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FDatasmithFacadeVisibilityAnimation(global::System.IntPtr cPtr, bool cMemoryOwn) : base(DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FDatasmithFacadeVisibilityAnimation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DatasmithFacadeCSharpPINVOKE.delete_FDatasmithFacadeVisibilityAnimation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public FDatasmithFacadeVisibilityAnimation(string InName) : this(DatasmithFacadeCSharpPINVOKE.new_FDatasmithFacadeVisibilityAnimation(InName), true) {
  }

  public void AddFrame(int FrameNumber, bool bVisible) {
    DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_AddFrame(swigCPtr, FrameNumber, bVisible);
  }

  public int GetFramesCount() {
    int ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_GetFramesCount(swigCPtr);
    return ret;
  }

  public void SetCurveInterpMode(EDatasmithFacadeCurveInterpMode CurveInterpMode) {
    DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_SetCurveInterpMode(swigCPtr, (int)CurveInterpMode);
  }

  public EDatasmithFacadeCurveInterpMode GetCurveInterpMode() {
    EDatasmithFacadeCurveInterpMode ret = (EDatasmithFacadeCurveInterpMode)DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_GetCurveInterpMode(swigCPtr);
    return ret;
  }

  public void GetFrame(int Index, out int OutFrameNumber, out bool bOutVisible) {
    DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_GetFrame(swigCPtr, Index, out OutFrameNumber, out bOutVisible);
  }

  public void RemoveFrame(int Index) {
    DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_RemoveFrame(swigCPtr, Index);
  }

  public void SetPropagateToChildren(bool bPropagate) {
    DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_SetPropagateToChildren(swigCPtr, bPropagate);
  }

  public bool GetPropagateToChildren() {
    bool ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeVisibilityAnimation_GetPropagateToChildren(swigCPtr);
    return ret;
  }

}