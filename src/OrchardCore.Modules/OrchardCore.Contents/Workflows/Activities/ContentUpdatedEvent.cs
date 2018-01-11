using Microsoft.Extensions.Localization;
using OrchardCore.ContentManagement;

namespace OrchardCore.Contents.Workflows.Activities
{
    public class ContentUpdatedEvent : ContentEvent
    {
        public ContentUpdatedEvent(IContentManager contentManager, IStringLocalizer<ContentCreatedEvent> localizer) : base(contentManager, localizer)
        {
        }

        public override string Name => nameof(ContentUpdatedEvent);
        public override LocalizedString Description => T["Content is updated."];
    }
}