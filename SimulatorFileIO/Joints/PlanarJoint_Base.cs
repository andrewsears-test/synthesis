﻿/*
 *Purpose: Contains the information for an Inventor planar joint.
 */


public class PlanarJoint_Base : SkeletalJoint_Base
{
    public BXDVector3 normal;
    public BXDVector3 basePoint;

    public override SkeletalJointType GetJointType()
    {
        return SkeletalJointType.PLANAR;
    }

    public override void WriteJoint(System.IO.BinaryWriter writer)
    {
        writer.Write(normal.x);
        writer.Write(normal.y);
        writer.Write(normal.z);

        writer.Write(basePoint.x);
        writer.Write(basePoint.y);
        writer.Write(basePoint.z);
    }

    protected override void ReadJoint(System.IO.BinaryReader reader)
    {
        normal = new BXDVector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
        basePoint = new BXDVector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
    }
}
