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

public class MgPath : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgPath(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgPath obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgPath() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgPath(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MgPath() : this(touchvgPINVOKE.new_MgPath__SWIG_0(), true) {
  }

  public MgPath(MgPath src) : this(touchvgPINVOKE.new_MgPath__SWIG_1(MgPath.getCPtr(src)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public MgPath(int count, Point2d points, string types) : this(touchvgPINVOKE.new_MgPath__SWIG_2(count, Point2d.getCPtr(points), types), true) {
  }

  public MgPath(string svgd) : this(touchvgPINVOKE.new_MgPath__SWIG_3(svgd), true) {
  }

  public MgPath copy(MgPath src) {
    MgPath ret = new MgPath(touchvgPINVOKE.MgPath_copy(swigCPtr, MgPath.getCPtr(src)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MgPath append(MgPath src) {
    MgPath ret = new MgPath(touchvgPINVOKE.MgPath_append(swigCPtr, MgPath.getCPtr(src)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MgPath addSVGPath(string s) {
    MgPath ret = new MgPath(touchvgPINVOKE.MgPath_addSVGPath(swigCPtr, s), false);
    return ret;
  }

  public MgPath reverse() {
    MgPath ret = new MgPath(touchvgPINVOKE.MgPath_reverse(swigCPtr), false);
    return ret;
  }

  public bool genericRoundLines(int count, Point2d points, float radius, bool closed) {
    bool ret = touchvgPINVOKE.MgPath_genericRoundLines__SWIG_0(swigCPtr, count, Point2d.getCPtr(points), radius, closed);
    return ret;
  }

  public bool genericRoundLines(int count, Point2d points, float radius) {
    bool ret = touchvgPINVOKE.MgPath_genericRoundLines__SWIG_1(swigCPtr, count, Point2d.getCPtr(points), radius);
    return ret;
  }

  public int getCount() {
    int ret = touchvgPINVOKE.MgPath_getCount(swigCPtr);
    return ret;
  }

  public int getSubPathCount() {
    int ret = touchvgPINVOKE.MgPath_getSubPathCount(swigCPtr);
    return ret;
  }

  public Point2d getStartPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgPath_getStartPoint(swigCPtr), true);
    return ret;
  }

  public Vector2d getStartTangent() {
    Vector2d ret = new Vector2d(touchvgPINVOKE.MgPath_getStartTangent(swigCPtr), true);
    return ret;
  }

  public Point2d getEndPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgPath_getEndPoint(swigCPtr), true);
    return ret;
  }

  public Vector2d getEndTangent() {
    Vector2d ret = new Vector2d(touchvgPINVOKE.MgPath_getEndTangent(swigCPtr), true);
    return ret;
  }

  public bool isLine() {
    bool ret = touchvgPINVOKE.MgPath_isLine(swigCPtr);
    return ret;
  }

  public bool isLines() {
    bool ret = touchvgPINVOKE.MgPath_isLines(swigCPtr);
    return ret;
  }

  public bool isCurve() {
    bool ret = touchvgPINVOKE.MgPath_isCurve(swigCPtr);
    return ret;
  }

  public bool isClosed() {
    bool ret = touchvgPINVOKE.MgPath_isClosed(swigCPtr);
    return ret;
  }

  public float getLength() {
    float ret = touchvgPINVOKE.MgPath_getLength(swigCPtr);
    return ret;
  }

  public int getNodeType(int index) {
    int ret = touchvgPINVOKE.MgPath_getNodeType(swigCPtr, index);
    return ret;
  }

  public Point2d getPoint(int index) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgPath_getPoint(swigCPtr, index), true);
    return ret;
  }

  public void setPoint(int index, Point2d pt) {
    touchvgPINVOKE.MgPath_setPoint(swigCPtr, index, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    touchvgPINVOKE.MgPath_clear(swigCPtr);
  }

  public void transform(Matrix2d mat) {
    touchvgPINVOKE.MgPath_transform(swigCPtr, Matrix2d.getCPtr(mat));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void startFigure() {
    touchvgPINVOKE.MgPath_startFigure(swigCPtr);
  }

  public bool moveTo(Point2d point, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_moveTo__SWIG_0(swigCPtr, Point2d.getCPtr(point), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool moveTo(Point2d point) {
    bool ret = touchvgPINVOKE.MgPath_moveTo__SWIG_1(swigCPtr, Point2d.getCPtr(point));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool lineTo(Point2d point, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_lineTo__SWIG_0(swigCPtr, Point2d.getCPtr(point), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool lineTo(Point2d point) {
    bool ret = touchvgPINVOKE.MgPath_lineTo__SWIG_1(swigCPtr, Point2d.getCPtr(point));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool horzTo(float x, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_horzTo__SWIG_0(swigCPtr, x, rel);
    return ret;
  }

  public bool horzTo(float x) {
    bool ret = touchvgPINVOKE.MgPath_horzTo__SWIG_1(swigCPtr, x);
    return ret;
  }

  public bool vertTo(float y, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_vertTo__SWIG_0(swigCPtr, y, rel);
    return ret;
  }

  public bool vertTo(float y) {
    bool ret = touchvgPINVOKE.MgPath_vertTo__SWIG_1(swigCPtr, y);
    return ret;
  }

  public bool linesTo(int count, Point2d points, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_linesTo__SWIG_0(swigCPtr, count, Point2d.getCPtr(points), rel);
    return ret;
  }

  public bool linesTo(int count, Point2d points) {
    bool ret = touchvgPINVOKE.MgPath_linesTo__SWIG_1(swigCPtr, count, Point2d.getCPtr(points));
    return ret;
  }

  public bool beziersTo(int count, Point2d points, bool reverse, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_beziersTo__SWIG_0(swigCPtr, count, Point2d.getCPtr(points), reverse, rel);
    return ret;
  }

  public bool beziersTo(int count, Point2d points, bool reverse) {
    bool ret = touchvgPINVOKE.MgPath_beziersTo__SWIG_1(swigCPtr, count, Point2d.getCPtr(points), reverse);
    return ret;
  }

  public bool beziersTo(int count, Point2d points) {
    bool ret = touchvgPINVOKE.MgPath_beziersTo__SWIG_2(swigCPtr, count, Point2d.getCPtr(points));
    return ret;
  }

  public bool bezierTo(Point2d cp1, Point2d cp2, Point2d end, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_bezierTo__SWIG_0(swigCPtr, Point2d.getCPtr(cp1), Point2d.getCPtr(cp2), Point2d.getCPtr(end), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool bezierTo(Point2d cp1, Point2d cp2, Point2d end) {
    bool ret = touchvgPINVOKE.MgPath_bezierTo__SWIG_1(swigCPtr, Point2d.getCPtr(cp1), Point2d.getCPtr(cp2), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool smoothBezierTo(Point2d cp2, Point2d end, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_smoothBezierTo__SWIG_0(swigCPtr, Point2d.getCPtr(cp2), Point2d.getCPtr(end), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool smoothBezierTo(Point2d cp2, Point2d end) {
    bool ret = touchvgPINVOKE.MgPath_smoothBezierTo__SWIG_1(swigCPtr, Point2d.getCPtr(cp2), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool quadsTo(int count, Point2d points, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_quadsTo__SWIG_0(swigCPtr, count, Point2d.getCPtr(points), rel);
    return ret;
  }

  public bool quadsTo(int count, Point2d points) {
    bool ret = touchvgPINVOKE.MgPath_quadsTo__SWIG_1(swigCPtr, count, Point2d.getCPtr(points));
    return ret;
  }

  public bool quadTo(Point2d cp, Point2d end, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_quadTo__SWIG_0(swigCPtr, Point2d.getCPtr(cp), Point2d.getCPtr(end), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool quadTo(Point2d cp, Point2d end) {
    bool ret = touchvgPINVOKE.MgPath_quadTo__SWIG_1(swigCPtr, Point2d.getCPtr(cp), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool smoothQuadTo(Point2d end, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_smoothQuadTo__SWIG_0(swigCPtr, Point2d.getCPtr(end), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool smoothQuadTo(Point2d end) {
    bool ret = touchvgPINVOKE.MgPath_smoothQuadTo__SWIG_1(swigCPtr, Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool arcTo(Point2d point, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_arcTo__SWIG_0(swigCPtr, Point2d.getCPtr(point), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool arcTo(Point2d point) {
    bool ret = touchvgPINVOKE.MgPath_arcTo__SWIG_1(swigCPtr, Point2d.getCPtr(point));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool arcTo(Point2d point, Point2d end, bool rel) {
    bool ret = touchvgPINVOKE.MgPath_arcTo__SWIG_2(swigCPtr, Point2d.getCPtr(point), Point2d.getCPtr(end), rel);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool arcTo(Point2d point, Point2d end) {
    bool ret = touchvgPINVOKE.MgPath_arcTo__SWIG_3(swigCPtr, Point2d.getCPtr(point), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool closeFigure() {
    bool ret = touchvgPINVOKE.MgPath_closeFigure(swigCPtr);
    return ret;
  }

  public bool trimStart(Point2d pt, float dist) {
    bool ret = touchvgPINVOKE.MgPath_trimStart(swigCPtr, Point2d.getCPtr(pt), dist);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool crossWithPath(MgPath path, Box2d box, Point2d ptCross) {
    bool ret = touchvgPINVOKE.MgPath_crossWithPath(swigCPtr, MgPath.getCPtr(path), Box2d.getCPtr(box), Point2d.getCPtr(ptCross));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
