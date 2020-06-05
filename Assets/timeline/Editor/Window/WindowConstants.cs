﻿namespace UnityEditor.Timeline
{
    class WindowConstants
    {
        public const float rowGap = 4;
        public const float timeAreaYPosition = 18.0f;
        public const float timeAreaHeight = 20.0f;

        public const float sliderWidth = 160.0f;
        public const float rightAreaMargn = 162.0f;

        public const float markerRowHeight = 18.0f;
        public const float markerRowYPosition = timeAreaYPosition + timeAreaHeight + rowGap;

        public const float trackRowYPosition = markerRowYPosition + markerRowHeight + rowGap;
        public const float defaultHeaderWidth = 307.0f;
        public const float defaultBindingAreaWidth = 40.0f;

        public const float minHierarchySplitter = 0.15f;
        public const float maxHierarchySplitter = 10.50f;
        public const float hierarchySplitterDefaultPercentage = 0.2f;

        public const float minHeaderWidth = 315.0f;
        public const float maxHeaderWidth = 650.0f;

        public const float minTimeCodeWidth = 28.0f; // Enough space to display up to 9999 without clipping

        public const float shadowUnderTimelineHeight = 15.0f;
        public const float refTimeWidth = 50.0f;

        public const float selectorWidth = 32.0f;
        public const float cogButtonWidth = 32.0f;
        public const float cogButtonPadding = 16.0f;

        public const float trackHeaderButtonSize = 16.0f;
        public const float trackHeaderButtonPadding = 6f;
        public const float trackOptionButtonVerticalPadding = 4f;
        public const float trackHeaderMaxButtonsWidth = 5 * (trackHeaderButtonSize + trackHeaderButtonPadding);

        public const float trackInsertionMarkerHeight = 1f;
    }
}
