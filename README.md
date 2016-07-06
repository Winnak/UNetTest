# Unity Networking and with generic methods.

**UNetWeaver error: Command [Strategist:CmdFireOrder] cannot have generic parameters**
``` 
UnityEngine.Debug:LogError(Object)
Unity.UNetWeaver.Log:Error(String) (at C:/buildslave/unity/build/Extensions/Networking/Weaver/Program.cs:20)
Unity.UNetWeaver.NetworkBehaviourProcessor:ProcessMethods() (at C:/buildslave/unity/build/Extensions/Networking/Weaver/UNetBehaviourProcessor.cs:1246)
Unity.UNetWeaver.NetworkBehaviourProcessor:Process() (at C:/buildslave/unity/build/Extensions/Networking/Weaver/UNetBehaviourProcessor.cs:56)
Unity.UNetWeaver.Weaver:ProcessNetworkBehaviourType(TypeDefinition) (at C:/buildslave/unity/build/Extensions/Networking/Weaver/UNetWeaver.cs:1064)
Unity.UNetWeaver.Weaver:CheckNetworkBehaviour(TypeDefinition) (at C:/buildslave/unity/build/Extensions/Networking/Weaver/UNetWeaver.cs:1549)
Unity.UNetWeaver.Weaver:Weave(String, IEnumerable`1, IAssemblyResolver, String, String, String) (at C:/buildslave/unity/build/Extensions/Networking/Weaver/UNetWeaver.cs:1658)
Unity.UNetWeaver.Weaver:WeaveAssemblies(IEnumerable`1, IEnumerable`1, IAssemblyResolver, String, String, String) (at C:/buildslave/unity/build/Extensions/Networking/Weaver/UNetWeaver.cs:1748)
Unity.UNetWeaver.Program:Process(String, String, String, String[], String[], IAssemblyResolver, Action`1, Action`1) (at C:/buildslave/unity/build/Extensions/Networking/Weaver/Program.cs:34)
UnityEditor.Scripting.Serialization.Weaver:WeaveUnetFromEditor(String, String, String, String, Boolean)
```

**Failure generating network code.**
```
UnityEditor.Scripting.Serialization.Weaver:WeaveUnetFromEditor(String, String, String, String, Boolean)
```
