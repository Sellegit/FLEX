using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FLEX {

  [BaseType (typeof (NSObject))]
  public partial interface FLEXManager {

    [Static, Export ("sharedManager")]
    FLEXManager SharedManager { get; }

    [Export ("isHidden")]
    bool IsHidden { get; }

    [Export ("showExplorer")]
    void ShowExplorer ();

    [Export ("hideExplorer")]
    void HideExplorer ();

  }
}