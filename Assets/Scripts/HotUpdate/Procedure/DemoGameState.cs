using System.Collections;
using System.Collections.Generic;
using F8Framework.Core;
using F8Framework.Launcher;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoGameState : ProcedureNode
{
    public override void OnInit(ProcedureProcessor processor)
    {
            
    }
        
    public override void OnEnter(ProcedureProcessor processor)
    {
        SceneManager.LoadScene("Main");
        FF8.UI.Open(DemoInitState.UIID.UIGameView);
    }
    
    public override void OnExit(ProcedureProcessor processor)
    {
            
    }
    
    public override void OnUpdate(ProcedureProcessor processor)
    {
            
    }
        
    public override void OnDestroy(ProcedureProcessor processor)
    {
            
    }
}
