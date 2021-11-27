using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierReaizaions : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Transform p0;
    [SerializeField] private Transform p1;
    [SerializeField] private Transform p2;
    [SerializeField] private Transform p3;
    [SerializeField][Range(0,1)] private float t;
    private float speed = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        while (true)
        {
            float t = Time.time * speed / 8;
            transform.position = UnityBezie.GetPoint(p0.position, p1.position, p2.position, p3.position, t);
            transform.rotation = Quaternion.LookRotation(UnityBezie.GetPointRotains(p0.position, p1.position, p2.position, p3.position, t));
            rb.isKinematic = true;
        }
        
        
    }
    private void OnDrawGizmos()
    {
        int point20ochek = 20;
        Vector3 startpositon = p0.position;
        for(int i = 0;i < point20ochek + 1;i++)
        {
            float parament = (float)i / point20ochek;
            Vector3 positonT = UnityBezie.GetPoint(p0.position, p1.position, p2.position, p3.position, parament);
            Gizmos.DrawLine(startpositon,positonT);
            startpositon = positonT;
        }

    }
}
