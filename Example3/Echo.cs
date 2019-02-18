using System;
using WebSocketCore;
using WebSocketCore.Server;

namespace Example3
{
  public class Echo : WebSocketBehavior
  {
    protected override void OnMessage (MessageEventArgs e)
    {
      var name = Context.QueryString["name"];
      Send (!name.IsNullOrEmpty () ? String.Format ("\"{0}\" to {1}", e.Data, name) : e.Data);
    }
  }
}
