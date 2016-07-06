using UnityEngine;
using UnityEngine.Networking;

public class Strategist : NetworkBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CmdFireOrder(new FooOrder(43));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CmdFireOrder(new BarOrder("Test"));
        }
    }

    [Command]
    private void CmdFireOrder<T>(T order) where T : struct
    {
        RpcHandleNewOrder(order);
    }

    [ClientRpc]
    private void RpcHandleNewOrder<T>(T order) where T : struct
    {
        Debug.Log(order.ToString());
    }
}