using Mirror;
using Mirror.Weaver.Tests.Extra;

namespace GeneratedReaderWriter.CreatesForClass
{
    public class CreatesForClass : NetworkBehaviour
    {
        [ClientRpc]
        public void RpcDoSomething(SomeOtherData data)
        {
            // empty
        }
    }

    public class SomeOtherData
    {
        public int usefulNumber;
    }
}
