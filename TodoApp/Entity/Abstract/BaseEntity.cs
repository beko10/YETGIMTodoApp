﻿namespace TodoApp.Entity.Abstract;

public  class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }
}
