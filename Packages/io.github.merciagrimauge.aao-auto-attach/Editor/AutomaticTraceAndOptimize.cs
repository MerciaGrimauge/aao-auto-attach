using Anatawa12.AvatarOptimizer;
using AvatarPlacement.Editor;
using EditorEventHandlers.Editor;
using UnityEditor;

namespace AAOAutoAttach.Editor
{
    [InitializeOnLoad]
    internal static class AutomaticTraceAndOptimize
    {
        private static readonly EventSubscription Registration;

        static AutomaticTraceAndOptimize()
        {
            Registration = EditorEvents.Subscribe<AvatarPlaced>(new AttachHandler());
        }

        private sealed class AttachHandler : IEventHandler<AvatarPlaced>
        {
            public string Id => "io.github.merciagrimauge.aao-auto-attach.trace-and-optimize";

            public HandlerResult Execute(HandlerContext<AvatarPlaced> context)
            {
                context.CheckDeadline();
                if (context.Root.TryGetComponent<TraceAndOptimize>(out _))
                    return HandlerResult.Skip("AAO is already present.");
                context.AddComponent<TraceAndOptimize>(context.Root);
                return HandlerResult.Success();
            }
        }
    }
}
