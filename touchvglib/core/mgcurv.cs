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

public class mgcurv : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal mgcurv(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(mgcurv obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~mgcurv() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_mgcurv(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static void fitBezier(Point2d pts, float t, Point2d fitpt) {
    touchvgPINVOKE.mgcurv_fitBezier(Point2d.getCPtr(pts), t, Point2d.getCPtr(fitpt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void bezierTanget(Point2d pts, float t, Point2d outpt) {
    touchvgPINVOKE.mgcurv_bezierTanget(Point2d.getCPtr(pts), t, Point2d.getCPtr(outpt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void splitBezier(Point2d pts, float t, Point2d pts1, Point2d pts2) {
    touchvgPINVOKE.mgcurv_splitBezier(Point2d.getCPtr(pts), t, Point2d.getCPtr(pts1), Point2d.getCPtr(pts2));
  }

  public static bool bezierIsStraight(Point2d pts) {
    bool ret = touchvgPINVOKE.mgcurv_bezierIsStraight(Point2d.getCPtr(pts));
    return ret;
  }

  public static float lengthOfBezier(Point2d pts) {
    float ret = touchvgPINVOKE.mgcurv_lengthOfBezier(Point2d.getCPtr(pts));
    return ret;
  }

  public static float bezierPointLengthFromStart(Point2d pts, float len) {
    float ret = touchvgPINVOKE.mgcurv_bezierPointLengthFromStart(Point2d.getCPtr(pts), len);
    return ret;
  }

  public static void bezier4P(Point2d pt1, Point2d pt2, Point2d pt3, Point2d pt4, Point2d ctrpt1, Point2d ctrpt2) {
    touchvgPINVOKE.mgcurv_bezier4P(Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), Point2d.getCPtr(pt3), Point2d.getCPtr(pt4), Point2d.getCPtr(ctrpt1), Point2d.getCPtr(ctrpt2));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static int fitCurve(int knotCount, Point2d knots, Vector2d knotvs, int count, Point2d pts, float tol) {
    int ret = touchvgPINVOKE.mgcurv_fitCurve(knotCount, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), count, Point2d.getCPtr(pts), tol);
    return ret;
  }

  public static void quadBezierToCubic(Point2d quad, Point2d cubic) {
    touchvgPINVOKE.mgcurv_quadBezierToCubic(Point2d.getCPtr(quad), Point2d.getCPtr(cubic));
  }

  public static void ellipse90ToBezier(Point2d frompt, Point2d topt, Point2d ctrpt1, Point2d ctrpt2) {
    touchvgPINVOKE.mgcurv_ellipse90ToBezier(Point2d.getCPtr(frompt), Point2d.getCPtr(topt), Point2d.getCPtr(ctrpt1), Point2d.getCPtr(ctrpt2));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void ellipseToBezier(Point2d points, Point2d center, float rx, float ry) {
    touchvgPINVOKE.mgcurv_ellipseToBezier(Point2d.getCPtr(points), Point2d.getCPtr(center), rx, ry);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void roundRectToBeziers(Point2d points, Box2d rect, float rx, float ry) {
    touchvgPINVOKE.mgcurv_roundRectToBeziers(Point2d.getCPtr(points), Box2d.getCPtr(rect), rx, ry);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static int arcToBezier(Point2d points, Point2d center, float rx, float ry, float startAngle, float sweepAngle) {
    int ret = touchvgPINVOKE.mgcurv_arcToBezier(Point2d.getCPtr(points), Point2d.getCPtr(center), rx, ry, startAngle, sweepAngle);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int crossTwoCircles(Point2d pt1, Point2d pt2, Point2d c1, float r1, Point2d c2, float r2) {
    int ret = touchvgPINVOKE.mgcurv_crossTwoCircles(Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), Point2d.getCPtr(c1), r1, Point2d.getCPtr(c2), r2);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int crossLineCircle(Point2d pt1, Point2d pt2, Point2d a, Point2d b, Point2d c, float r, bool ray) {
    int ret = touchvgPINVOKE.mgcurv_crossLineCircle__SWIG_0(Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), Point2d.getCPtr(a), Point2d.getCPtr(b), Point2d.getCPtr(c), r, ray);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int crossLineCircle(Point2d pt1, Point2d pt2, Point2d a, Point2d b, Point2d c, float r) {
    int ret = touchvgPINVOKE.mgcurv_crossLineCircle__SWIG_1(Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), Point2d.getCPtr(a), Point2d.getCPtr(b), Point2d.getCPtr(c), r);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool cubicSplines(int n, Point2d knots, Vector2d knotvs, int flag, float tension) {
    bool ret = touchvgPINVOKE.mgcurv_cubicSplines__SWIG_0(n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), flag, tension);
    return ret;
  }

  public static bool cubicSplines(int n, Point2d knots, Vector2d knotvs, int flag) {
    bool ret = touchvgPINVOKE.mgcurv_cubicSplines__SWIG_1(n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), flag);
    return ret;
  }

  public static bool cubicSplines(int n, Point2d knots, Vector2d knotvs) {
    bool ret = touchvgPINVOKE.mgcurv_cubicSplines__SWIG_2(n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs));
    return ret;
  }

  public static void fitCubicSpline(int n, Point2d knots, Vector2d knotvs, int i, float t, Point2d fitpt) {
    touchvgPINVOKE.mgcurv_fitCubicSpline(n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), i, t, Point2d.getCPtr(fitpt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void cubicSplineToBezier(int n, Point2d knots, Vector2d knotvs, int i, Point2d points, bool hermite) {
    touchvgPINVOKE.mgcurv_cubicSplineToBezier__SWIG_0(n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), i, Point2d.getCPtr(points), hermite);
  }

  public static void cubicSplineToBezier(int n, Point2d knots, Vector2d knotvs, int i, Point2d points) {
    touchvgPINVOKE.mgcurv_cubicSplineToBezier__SWIG_1(n, Point2d.getCPtr(knots), Vector2d.getCPtr(knotvs), i, Point2d.getCPtr(points));
  }

  public static int bsplinesToBeziers(Point2d points, int n, Point2d ctlpts, bool closed) {
    int ret = touchvgPINVOKE.mgcurv_bsplinesToBeziers(Point2d.getCPtr(points), n, Point2d.getCPtr(ctlpts), closed);
    return ret;
  }

  public mgcurv() : this(touchvgPINVOKE.new_mgcurv(), true) {
  }

  public enum SplineFlags {
    cubicTan1 = 1,
    cubicArm1 = 2,
    cubicTan2 = 4,
    cubicArm2 = 8,
    cubicLoop = 16
  }

}

}
