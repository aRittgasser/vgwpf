//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace touchvg.core {

public class MgBaseLines : MgBaseShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MgBaseLines(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgBaseLines_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgBaseLines obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new static int Type() {
    int ret = touchvgPINVOKE.MgBaseLines_Type();
    return ret;
  }

  public void setClosed(bool closed) {
    touchvgPINVOKE.MgBaseLines_setClosed(swigCPtr, closed);
  }

  public Point2d endPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgBaseLines_endPoint(swigCPtr), true);
    return ret;
  }

  public virtual bool resize(int count) {
    bool ret = (SwigDerivedClassHasMethod("resize", swigMethodTypes36) ? touchvgPINVOKE.MgBaseLines_resizeSwigExplicitMgBaseLines(swigCPtr, count) : touchvgPINVOKE.MgBaseLines_resize(swigCPtr, count));
    return ret;
  }

  public virtual bool addPoint(Point2d pt) {
    bool ret = (SwigDerivedClassHasMethod("addPoint", swigMethodTypes37) ? touchvgPINVOKE.MgBaseLines_addPointSwigExplicitMgBaseLines(swigCPtr, Point2d.getCPtr(pt)) : touchvgPINVOKE.MgBaseLines_addPoint(swigCPtr, Point2d.getCPtr(pt)));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool insertPoint(int segment, Point2d pt) {
    bool ret = (SwigDerivedClassHasMethod("insertPoint", swigMethodTypes38) ? touchvgPINVOKE.MgBaseLines_insertPointSwigExplicitMgBaseLines(swigCPtr, segment, Point2d.getCPtr(pt)) : touchvgPINVOKE.MgBaseLines_insertPoint(swigCPtr, segment, Point2d.getCPtr(pt)));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool removePoint(int index) {
    bool ret = (SwigDerivedClassHasMethod("removePoint", swigMethodTypes39) ? touchvgPINVOKE.MgBaseLines_removePointSwigExplicitMgBaseLines(swigCPtr, index) : touchvgPINVOKE.MgBaseLines_removePoint(swigCPtr, index));
    return ret;
  }

  public int maxEdgeIndex() {
    int ret = touchvgPINVOKE.MgBaseLines_maxEdgeIndex(swigCPtr);
    return ret;
  }

  public bool isIncrementFrom(MgBaseLines src) {
    bool ret = touchvgPINVOKE.MgBaseLines_isIncrementFrom(swigCPtr, MgBaseLines.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  protected MgBaseLines() : this(touchvgPINVOKE.new_MgBaseLines(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("clone", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgBaseLines_0(SwigDirectorclone);
    if (SwigDerivedClassHasMethod("copy", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgBaseLines_1(SwigDirectorcopy);
    if (SwigDerivedClassHasMethod("release", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgBaseLines_2(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("addRef", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgBaseLines_3(SwigDirectoraddRef);
    if (SwigDerivedClassHasMethod("equals", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgBaseLines_4(SwigDirectorequals);
    if (SwigDerivedClassHasMethod("getType", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgBaseLines_5(SwigDirectorgetType);
    if (SwigDerivedClassHasMethod("isKindOf", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgBaseLines_6(SwigDirectorisKindOf);
    if (SwigDerivedClassHasMethod("getExtent", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgBaseLines_7(SwigDirectorgetExtent);
    if (SwigDerivedClassHasMethod("getChangeCount", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgBaseLines_8(SwigDirectorgetChangeCount);
    if (SwigDerivedClassHasMethod("resetChangeCount", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgBaseLines_9(SwigDirectorresetChangeCount);
    if (SwigDerivedClassHasMethod("afterChanged", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgBaseLines_10(SwigDirectorafterChanged);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgBaseLines_11(SwigDirectorupdate);
    if (SwigDerivedClassHasMethod("transform", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgBaseLines_12(SwigDirectortransform);
    if (SwigDerivedClassHasMethod("clear", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgBaseLines_13(SwigDirectorclear);
    if (SwigDerivedClassHasMethod("clearCachedData", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgBaseLines_14(SwigDirectorclearCachedData);
    if (SwigDerivedClassHasMethod("getPointCount", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgBaseLines_15(SwigDirectorgetPointCount);
    if (SwigDerivedClassHasMethod("getPoint", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgBaseLines_16(SwigDirectorgetPoint);
    if (SwigDerivedClassHasMethod("setPoint", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMgBaseLines_17(SwigDirectorsetPoint);
    if (SwigDerivedClassHasMethod("isClosed", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateMgBaseLines_18(SwigDirectorisClosed);
    if (SwigDerivedClassHasMethod("isCurve", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateMgBaseLines_19(SwigDirectorisCurve);
    if (SwigDerivedClassHasMethod("hitTest", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateMgBaseLines_20(SwigDirectorhitTest);
    if (SwigDerivedClassHasMethod("hitTestBox", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateMgBaseLines_21(SwigDirectorhitTestBox);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateMgBaseLines_22(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("draw2", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateMgBaseLines_23(SwigDirectordraw2);
    if (SwigDerivedClassHasMethod("output", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateMgBaseLines_24(SwigDirectoroutput);
    if (SwigDerivedClassHasMethod("save", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateMgBaseLines_25(SwigDirectorsave);
    if (SwigDerivedClassHasMethod("load", swigMethodTypes26))
      swigDelegate26 = new SwigDelegateMgBaseLines_26(SwigDirectorload);
    if (SwigDerivedClassHasMethod("getHandleCount", swigMethodTypes27))
      swigDelegate27 = new SwigDelegateMgBaseLines_27(SwigDirectorgetHandleCount);
    if (SwigDerivedClassHasMethod("getHandlePoint", swigMethodTypes28))
      swigDelegate28 = new SwigDelegateMgBaseLines_28(SwigDirectorgetHandlePoint);
    if (SwigDerivedClassHasMethod("setHandlePoint", swigMethodTypes29))
      swigDelegate29 = new SwigDelegateMgBaseLines_29(SwigDirectorsetHandlePoint);
    if (SwigDerivedClassHasMethod("isHandleFixed", swigMethodTypes30))
      swigDelegate30 = new SwigDelegateMgBaseLines_30(SwigDirectorisHandleFixed);
    if (SwigDerivedClassHasMethod("getHandleType", swigMethodTypes31))
      swigDelegate31 = new SwigDelegateMgBaseLines_31(SwigDirectorgetHandleType);
    if (SwigDerivedClassHasMethod("offset", swigMethodTypes32))
      swigDelegate32 = new SwigDelegateMgBaseLines_32(SwigDirectoroffset);
    if (SwigDerivedClassHasMethod("setFlag", swigMethodTypes33))
      swigDelegate33 = new SwigDelegateMgBaseLines_33(SwigDirectorsetFlag);
    if (SwigDerivedClassHasMethod("setOwner", swigMethodTypes34))
      swigDelegate34 = new SwigDelegateMgBaseLines_34(SwigDirectorsetOwner);
    if (SwigDerivedClassHasMethod("getSubType", swigMethodTypes35))
      swigDelegate35 = new SwigDelegateMgBaseLines_35(SwigDirectorgetSubType);
    if (SwigDerivedClassHasMethod("resize", swigMethodTypes36))
      swigDelegate36 = new SwigDelegateMgBaseLines_36(SwigDirectorresize);
    if (SwigDerivedClassHasMethod("addPoint", swigMethodTypes37))
      swigDelegate37 = new SwigDelegateMgBaseLines_37(SwigDirectoraddPoint);
    if (SwigDerivedClassHasMethod("insertPoint", swigMethodTypes38))
      swigDelegate38 = new SwigDelegateMgBaseLines_38(SwigDirectorinsertPoint);
    if (SwigDerivedClassHasMethod("removePoint", swigMethodTypes39))
      swigDelegate39 = new SwigDelegateMgBaseLines_39(SwigDirectorremovePoint);
    touchvgPINVOKE.MgBaseLines_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25, swigDelegate26, swigDelegate27, swigDelegate28, swigDelegate29, swigDelegate30, swigDelegate31, swigDelegate32, swigDelegate33, swigDelegate34, swigDelegate35, swigDelegate36, swigDelegate37, swigDelegate38, swigDelegate39);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgBaseLines));
    return hasDerivedMethod;
  }

  private global::System.IntPtr SwigDirectorclone() {
    return MgObject.getCPtr(clone()).Handle;
  }

  private void SwigDirectorcopy(global::System.IntPtr src) {
    copy(new MgObject(src, false));
  }

  private void SwigDirectorrelease() {
    release();
  }

  private void SwigDirectoraddRef() {
    addRef();
  }

  private bool SwigDirectorequals(global::System.IntPtr src) {
    return equals(new MgObject(src, false));
  }

  private int SwigDirectorgetType() {
    return getType();
  }

  private bool SwigDirectorisKindOf(int type) {
    return isKindOf(type);
  }

  private global::System.IntPtr SwigDirectorgetExtent() {
    return Box2d.getCPtr(getExtent()).Handle;
  }

  private int SwigDirectorgetChangeCount() {
    return getChangeCount();
  }

  private void SwigDirectorresetChangeCount(int count) {
    resetChangeCount(count);
  }

  private void SwigDirectorafterChanged() {
    afterChanged();
  }

  private void SwigDirectorupdate() {
    update();
  }

  private void SwigDirectortransform(global::System.IntPtr mat) {
    transform(new Matrix2d(mat, false));
  }

  private void SwigDirectorclear() {
    clear();
  }

  private void SwigDirectorclearCachedData() {
    clearCachedData();
  }

  private int SwigDirectorgetPointCount() {
    return getPointCount();
  }

  private global::System.IntPtr SwigDirectorgetPoint(int index) {
    return Point2d.getCPtr(getPoint(index)).Handle;
  }

  private void SwigDirectorsetPoint(int index, global::System.IntPtr pt) {
    setPoint(index, new Point2d(pt, false));
  }

  private bool SwigDirectorisClosed() {
    return isClosed();
  }

  private bool SwigDirectorisCurve() {
    return isCurve();
  }

  private float SwigDirectorhitTest(global::System.IntPtr pt, float tol, global::System.IntPtr res) {
    return hitTest(new Point2d(pt, false), tol, new MgHitResult(res, false));
  }

  private bool SwigDirectorhitTestBox(global::System.IntPtr rect) {
    return hitTestBox(new Box2d(rect, false));
  }

  private bool SwigDirectordraw(int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment) {
    return draw(mode, new GiGraphics(gs, false), new GiContext(ctx, false), segment);
  }

  private bool SwigDirectordraw2(global::System.IntPtr owner, int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment) {
    return draw2((owner == global::System.IntPtr.Zero) ? null : new MgObject(owner, false), mode, new GiGraphics(gs, false), new GiContext(ctx, false), segment);
  }

  private void SwigDirectoroutput(global::System.IntPtr path) {
    output(new MgPath(path, false));
  }

  private bool SwigDirectorsave(global::System.IntPtr s) {
    return save((s == global::System.IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private bool SwigDirectorload(global::System.IntPtr factory, global::System.IntPtr s) {
    return load((factory == global::System.IntPtr.Zero) ? null : new MgShapeFactory(factory, false), (s == global::System.IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private int SwigDirectorgetHandleCount() {
    return getHandleCount();
  }

  private global::System.IntPtr SwigDirectorgetHandlePoint(int index) {
    return Point2d.getCPtr(getHandlePoint(index)).Handle;
  }

  private bool SwigDirectorsetHandlePoint(int index, global::System.IntPtr pt, float tol) {
    return setHandlePoint(index, new Point2d(pt, false), tol);
  }

  private bool SwigDirectorisHandleFixed(int index) {
    return isHandleFixed(index);
  }

  private int SwigDirectorgetHandleType(int index) {
    return getHandleType(index);
  }

  private bool SwigDirectoroffset(global::System.IntPtr vec, int segment) {
    return offset(new Vector2d(vec, false), segment);
  }

  private void SwigDirectorsetFlag(int bit, bool on) {
    setFlag((MgShapeBit)bit, on);
  }

  private void SwigDirectorsetOwner(global::System.IntPtr owner) {
    setOwner((owner == global::System.IntPtr.Zero) ? null : new MgObject(owner, false));
  }

  private int SwigDirectorgetSubType() {
    return getSubType();
  }

  private bool SwigDirectorresize(int count) {
    return resize(count);
  }

  private bool SwigDirectoraddPoint(global::System.IntPtr pt) {
    return addPoint(new Point2d(pt, false));
  }

  private bool SwigDirectorinsertPoint(int segment, global::System.IntPtr pt) {
    return insertPoint(segment, new Point2d(pt, false));
  }

  private bool SwigDirectorremovePoint(int index) {
    return removePoint(index);
  }

  public delegate global::System.IntPtr SwigDelegateMgBaseLines_0();
  public delegate void SwigDelegateMgBaseLines_1(global::System.IntPtr src);
  public delegate void SwigDelegateMgBaseLines_2();
  public delegate void SwigDelegateMgBaseLines_3();
  public delegate bool SwigDelegateMgBaseLines_4(global::System.IntPtr src);
  public delegate int SwigDelegateMgBaseLines_5();
  public delegate bool SwigDelegateMgBaseLines_6(int type);
  public delegate global::System.IntPtr SwigDelegateMgBaseLines_7();
  public delegate int SwigDelegateMgBaseLines_8();
  public delegate void SwigDelegateMgBaseLines_9(int count);
  public delegate void SwigDelegateMgBaseLines_10();
  public delegate void SwigDelegateMgBaseLines_11();
  public delegate void SwigDelegateMgBaseLines_12(global::System.IntPtr mat);
  public delegate void SwigDelegateMgBaseLines_13();
  public delegate void SwigDelegateMgBaseLines_14();
  public delegate int SwigDelegateMgBaseLines_15();
  public delegate global::System.IntPtr SwigDelegateMgBaseLines_16(int index);
  public delegate void SwigDelegateMgBaseLines_17(int index, global::System.IntPtr pt);
  public delegate bool SwigDelegateMgBaseLines_18();
  public delegate bool SwigDelegateMgBaseLines_19();
  public delegate float SwigDelegateMgBaseLines_20(global::System.IntPtr pt, float tol, global::System.IntPtr res);
  public delegate bool SwigDelegateMgBaseLines_21(global::System.IntPtr rect);
  public delegate bool SwigDelegateMgBaseLines_22(int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment);
  public delegate bool SwigDelegateMgBaseLines_23(global::System.IntPtr owner, int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment);
  public delegate void SwigDelegateMgBaseLines_24(global::System.IntPtr path);
  public delegate bool SwigDelegateMgBaseLines_25(global::System.IntPtr s);
  public delegate bool SwigDelegateMgBaseLines_26(global::System.IntPtr factory, global::System.IntPtr s);
  public delegate int SwigDelegateMgBaseLines_27();
  public delegate global::System.IntPtr SwigDelegateMgBaseLines_28(int index);
  public delegate bool SwigDelegateMgBaseLines_29(int index, global::System.IntPtr pt, float tol);
  public delegate bool SwigDelegateMgBaseLines_30(int index);
  public delegate int SwigDelegateMgBaseLines_31(int index);
  public delegate bool SwigDelegateMgBaseLines_32(global::System.IntPtr vec, int segment);
  public delegate void SwigDelegateMgBaseLines_33(int bit, bool on);
  public delegate void SwigDelegateMgBaseLines_34(global::System.IntPtr owner);
  public delegate int SwigDelegateMgBaseLines_35();
  public delegate bool SwigDelegateMgBaseLines_36(int count);
  public delegate bool SwigDelegateMgBaseLines_37(global::System.IntPtr pt);
  public delegate bool SwigDelegateMgBaseLines_38(int segment, global::System.IntPtr pt);
  public delegate bool SwigDelegateMgBaseLines_39(int index);

  private SwigDelegateMgBaseLines_0 swigDelegate0;
  private SwigDelegateMgBaseLines_1 swigDelegate1;
  private SwigDelegateMgBaseLines_2 swigDelegate2;
  private SwigDelegateMgBaseLines_3 swigDelegate3;
  private SwigDelegateMgBaseLines_4 swigDelegate4;
  private SwigDelegateMgBaseLines_5 swigDelegate5;
  private SwigDelegateMgBaseLines_6 swigDelegate6;
  private SwigDelegateMgBaseLines_7 swigDelegate7;
  private SwigDelegateMgBaseLines_8 swigDelegate8;
  private SwigDelegateMgBaseLines_9 swigDelegate9;
  private SwigDelegateMgBaseLines_10 swigDelegate10;
  private SwigDelegateMgBaseLines_11 swigDelegate11;
  private SwigDelegateMgBaseLines_12 swigDelegate12;
  private SwigDelegateMgBaseLines_13 swigDelegate13;
  private SwigDelegateMgBaseLines_14 swigDelegate14;
  private SwigDelegateMgBaseLines_15 swigDelegate15;
  private SwigDelegateMgBaseLines_16 swigDelegate16;
  private SwigDelegateMgBaseLines_17 swigDelegate17;
  private SwigDelegateMgBaseLines_18 swigDelegate18;
  private SwigDelegateMgBaseLines_19 swigDelegate19;
  private SwigDelegateMgBaseLines_20 swigDelegate20;
  private SwigDelegateMgBaseLines_21 swigDelegate21;
  private SwigDelegateMgBaseLines_22 swigDelegate22;
  private SwigDelegateMgBaseLines_23 swigDelegate23;
  private SwigDelegateMgBaseLines_24 swigDelegate24;
  private SwigDelegateMgBaseLines_25 swigDelegate25;
  private SwigDelegateMgBaseLines_26 swigDelegate26;
  private SwigDelegateMgBaseLines_27 swigDelegate27;
  private SwigDelegateMgBaseLines_28 swigDelegate28;
  private SwigDelegateMgBaseLines_29 swigDelegate29;
  private SwigDelegateMgBaseLines_30 swigDelegate30;
  private SwigDelegateMgBaseLines_31 swigDelegate31;
  private SwigDelegateMgBaseLines_32 swigDelegate32;
  private SwigDelegateMgBaseLines_33 swigDelegate33;
  private SwigDelegateMgBaseLines_34 swigDelegate34;
  private SwigDelegateMgBaseLines_35 swigDelegate35;
  private SwigDelegateMgBaseLines_36 swigDelegate36;
  private SwigDelegateMgBaseLines_37 swigDelegate37;
  private SwigDelegateMgBaseLines_38 swigDelegate38;
  private SwigDelegateMgBaseLines_39 swigDelegate39;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(MgObject) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(MgObject) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(Matrix2d) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] { typeof(int), typeof(Point2d) };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(Point2d), typeof(float), typeof(MgHitResult) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(Box2d) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(int), typeof(GiGraphics), typeof(GiContext), typeof(int) };
  private static global::System.Type[] swigMethodTypes23 = new global::System.Type[] { typeof(MgObject), typeof(int), typeof(GiGraphics), typeof(GiContext), typeof(int) };
  private static global::System.Type[] swigMethodTypes24 = new global::System.Type[] { typeof(MgPath) };
  private static global::System.Type[] swigMethodTypes25 = new global::System.Type[] { typeof(MgStorage) };
  private static global::System.Type[] swigMethodTypes26 = new global::System.Type[] { typeof(MgShapeFactory), typeof(MgStorage) };
  private static global::System.Type[] swigMethodTypes27 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes28 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes29 = new global::System.Type[] { typeof(int), typeof(Point2d), typeof(float) };
  private static global::System.Type[] swigMethodTypes30 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes31 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes32 = new global::System.Type[] { typeof(Vector2d), typeof(int) };
  private static global::System.Type[] swigMethodTypes33 = new global::System.Type[] { typeof(MgShapeBit), typeof(bool) };
  private static global::System.Type[] swigMethodTypes34 = new global::System.Type[] { typeof(MgObject) };
  private static global::System.Type[] swigMethodTypes35 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes36 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes37 = new global::System.Type[] { typeof(Point2d) };
  private static global::System.Type[] swigMethodTypes38 = new global::System.Type[] { typeof(int), typeof(Point2d) };
  private static global::System.Type[] swigMethodTypes39 = new global::System.Type[] { typeof(int) };
}

}
