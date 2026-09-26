// SPDX-License-Identifier: AGPL-3.0-or-later

using System.Numerics;
using Content.Shared._Arcane.Spline;
using Content.Shared._Arcane.Trail;
using Robust.Client.Graphics;
using Vector4 = System.Numerics.Vector4;

namespace Content.Client._Arcane.Trail.SplineRenderer;

public interface ITrailSplineRenderer
{
    void Render(
        DrawingHandleWorld handle,
        Texture? texture,
        ISpline<Vector2> splineIterator,
        ISpline<Vector4> gradientIterator,
        ITrailSettings settings,
        Vector2[] paPositions,
        float[] paLifetimes
    );
}
