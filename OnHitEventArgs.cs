using UnityEngine;



    public class OnHitEventArgs
    {
    public Vector3 TargetPosition { get; set; }

    public Vector3 TargetHitForce { get; set ; }

    public Vector3 TargetHitPosition { get; set; }

    public BallController HitterBallController;

    public OnHitEventArgs() { }

    public OnHitEventArgs(Vector3 targethitforce)
    {
        TargetHitForce = targethitforce;
    }

    public OnHitEventArgs(
        BallController hitterballcontroller,
        Vector3 targethitforce, 
        Vector3 targethitposition, 
        Vector3 targetposition)
    {
        HitterBallController = hitterballcontroller;
        TargetPosition = targetposition;
        TargetHitForce = targethitforce;
        TargetHitPosition = targethitposition;

    }public OnHitEventArgs(
        Vector3 targethitforce, 
        Vector3 targethitposition, 
        Vector3 targetposition)
    {
        TargetPosition = targetposition;
        TargetHitForce = targethitforce;
        TargetHitPosition = targethitposition;

    }
}

