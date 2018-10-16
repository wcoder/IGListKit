//
// ViewController.cs
//
// Author:
//       Yauheni Pakala <evgeniy.pakalo@gmail.com>
//
// Copyright (c) 2018 Yauheni Pakala
//
using System;
using CoreGraphics;
using IGListKit;
using ObjCRuntime;
using UIKit;

namespace IGListKitDemo
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
        }
    }

    // TODO:
    public class LabelSectionController : IGListSectionController
    {
        public override CGSize SizeForItemAtIndex(nint index)
        {
            return new CGSize((nfloat)CollectionContext?.ContainerSize.Width, 55f);
        }

        public override UICollectionViewCell CellForItemAtIndex(nint index)
        {
            var cell = CollectionContext?.DequeueReusableCellOfClass(new Class(typeof(MyCollectionViewCell)), this, index);
            return cell;
        }
    }
}
