
using UnityEngine;
using Cinemachine;


public class SwitchConfinerBounindShape : MonoBehaviour
{
    private void Start()
    {
        SwitchBoundingShape();
    }

    private void SwitchBoundingShape()
    {
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();

        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();

        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        cinemachineConfiner.InvalidatePathCache();

    }
    
}
