using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class trackedThing
{
    public GameObject fingerCollider;
    public OVRSkeleton.BoneId singleBone;
}

public class handTracking : MonoBehaviour
{
    public OVRSkeleton skeleton;
    public trackedThing[] bones;

    void Update()
    {
        foreach (trackedThing single in bones)
        {
            foreach (OVRBone bone in skeleton.Bones)
            {
                if (bone.Id == single.singleBone)
                {
                    single.fingerCollider.transform.SetParent(bone.Transform);
                    single.fingerCollider.transform.localPosition = new Vector3(0, 0, 0);
                }
            }
        }
    }
}
