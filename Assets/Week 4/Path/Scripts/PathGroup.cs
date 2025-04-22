using UnityEngine;

public enum PathType
{
    Straight,
    Zigzag,
    Circle,
    Spiral,
    Random
}

public class PathGroup : MonoBehaviour
{
    public PathType pathType;

    public Point GetStartPoint()
    {
        if (transform.childCount == 0) return null;
        return transform.GetChild(0).GetComponent<Point>();
    }
}
