//
// Structs.cs
//
// Author:
//       Yauheni Pakala <evgeniy.pakalo@gmail.com>
//
// Copyright (c) 2018 Yauheni Pakala
//
using ObjCRuntime;

namespace IGListKit
{
    [Native]
    public enum IGListDiffOption : long
    {
        PointerPersonality,
        Equality
    }

    //static class CFunctions
    //{
    //    // extern IGListIndexSetResult * _Nonnull IGListDiff (NSArray<id<IGListDiffable>> * _Nullable oldArray, NSArray<id<IGListDiffable>> * _Nullable newArray, IGListDiffOption option);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern IGListIndexSetResult IGListDiff([NullAllowed] IGListDiffable[] oldArray, [NullAllowed] IGListDiffable[] newArray, IGListDiffOption option);

    //    // extern IGListIndexPathResult * _Nonnull IGListDiffPaths (NSInteger fromSection, NSInteger toSection, NSArray<id<IGListDiffable>> * _Nullable oldArray, NSArray<id<IGListDiffable>> * _Nullable newArray, IGListDiffOption option);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern IGListIndexPathResult IGListDiffPaths(nint fromSection, nint toSection, [NullAllowed] IGListDiffable[] oldArray, [NullAllowed] IGListDiffable[] newArray, IGListDiffOption option);

    //    // BOOL IGListExperimentEnabled (IGListExperiment mask, IGListExperiment option);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern bool IGListExperimentEnabled(IGListExperiment mask, IGListExperiment option);

    //    // extern IGListIndexSetResult * _Nonnull IGListDiffExperiment (NSArray<id<IGListDiffable>> * _Nullable oldArray, NSArray<id<IGListDiffable>> * _Nullable newArray, IGListDiffOption option, IGListExperiment experiments);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern IGListIndexSetResult IGListDiffExperiment([NullAllowed] IGListDiffable[] oldArray, [NullAllowed] IGListDiffable[] newArray, IGListDiffOption option, IGListExperiment experiments);

    //    // extern IGListIndexPathResult * _Nonnull IGListDiffPathsExperiment (NSInteger fromSection, NSInteger toSection, NSArray<id<IGListDiffable>> * _Nullable oldArray, NSArray<id<IGListDiffable>> * _Nullable newArray, IGListDiffOption option, IGListExperiment experiments);
    //    [DllImport("__Internal")]
    //    [Verify(PlatformInvoke)]
    //    static extern IGListIndexPathResult IGListDiffPathsExperiment(nint fromSection, nint toSection, [NullAllowed] IGListDiffable[] oldArray, [NullAllowed] IGListDiffable[] newArray, IGListDiffOption option, IGListExperiment experiments);
    //}

    [Native]
    public enum IGListExperiment : long
    {
        None = 1 << 1,
        BackgroundDiffing = 1 << 2,
        ReloadDataFallback = 1 << 3,
        FasterVisibleSectionController = 1 << 4,
        DedupeItemUpdates = 1 << 5,
        DeferredToObjectCreation = 1 << 6
    }

    [Native]
    public enum IGListAdapterUpdateType : long
    {
        PerformUpdates,
        ReloadData,
        ItemUpdates
    }
}
