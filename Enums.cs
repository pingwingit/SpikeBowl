using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public enum Locations
    {
        PITCH,
        RESERVES,
        KO,
        INJURY,
        DEAD,
        SENT_OFF
    }  
    
    public enum PlayerStatus
    {
        STANDING,
        KNOCKED_DOWN,
        STUNNED,
        KO,
        INJURED,
        DEAD,
        RESERVE
    } 

    public enum ActionResults
    {
        TOUCHDOWN,
        TURNOVER,
        OK_CONTINUE,    //this is returned if a player's action is successful and they can carry on to do further actions, e.g. moved but have some movement allowance left
        OK_STOP //action was successful (i.e. not a turnover) but the player's turn is over, e.g. run out of move allowance, wrestler fell over etc.
    }

    public enum Side
    {
        HOME,
        AWAY
    }

    public enum RerollRequestMessages
    {
        DODGE_FAILED,
        PASS_INACCURATE,
        PASS_FUMBLED,
        CATCH_FAILED,
        PICKUP_FAILED,
        GFI_FAILED

        //TODO - should tentacles and shadowing be here (could use these in own turn on pass block opponent)
        //possible Pro might allow rerolls for these too
    }

    public enum RollTypes
    {
        D6,
        _2D6,
        _3D6,
        D3,
        D8,
        D16,
        D68
    }

    public enum Skills
    {

    }
}
