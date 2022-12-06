using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToStaffLounge : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("InLounge", 1);
        return true;
    }
}
