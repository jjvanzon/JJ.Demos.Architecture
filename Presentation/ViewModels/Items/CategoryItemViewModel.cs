﻿namespace JJ.Demos.Architecture.Presentation.ViewModels.Items;

public class CategoryItemViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string UsedBy { get; set; }
    public bool CanDelete { get; set; }
}
