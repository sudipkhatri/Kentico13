﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Linq;


namespace DancingGoat.Widgets
{
    /// <summary>
    /// Cafe card widget properties.
    /// </summary>
    public class CafeCardProperties : IWidgetProperties
    {
        /// <summary>
        /// Selected cafes.
        /// </summary>
        [EditingComponent(PageSelector.IDENTIFIER, Label = "Cafe", Order = 1)]
        [EditingComponentProperty(nameof(PageSelectorProperties.RootPath), ContentItemIdentifiers.CAFES)]
        [EditingComponentProperty(nameof(PageSelectorProperties.MaxPagesLimit), 1)]
        [Required]
        public IEnumerable<PageSelectorItem> SelectedCafes { get; set; } = new List<PageSelectorItem>();

        // Assigns a selector component to the 'Images' property
        [EditingComponent(MediaFilesSelector.IDENTIFIER)]
        // Configures the media library from which you can select files in the selector
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), "Graphics")]
        // Limits the maximum number of files that can be selected at once
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 5)]
        // Configures the allowed file extensions for the selected files
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")]
        // Returns a list of media files selector items (objects that contain the GUIDs of selected media files)
        public IEnumerable<MediaFilesSelectorItem> Images { get; set; } = Enumerable.Empty<MediaFilesSelectorItem>();


    }

}