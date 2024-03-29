﻿namespace JJ.Demos.Architecture.Data.Entities;

public class Customer : Party
{
    public virtual int ID { get; set; }
    public virtual string Name { get; set; }
    public virtual string CustomerNumber { get; set; }
}