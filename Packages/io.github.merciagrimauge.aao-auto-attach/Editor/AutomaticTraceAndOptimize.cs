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
            Registration = EditorEvents.Subscribe<AvatarAddedToScene>(new AttachHandler());
        }

        private sealed class AttachHandler : IEventHandler<AvatarAddedToScene>
        {
            public string Id => "io.github.merciagrimauge.aao-auto-attach.trace-and-optimize";

            public HandlerResult Execute(HandlerContext<AvatarAddedToScene> context)
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
