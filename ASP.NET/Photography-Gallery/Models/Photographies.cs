using System;
using System.Collections.Generic;
public class Photographies
{

    public List<photography> GetAllPhotographies()
    {
        return new List<photography>
        {
            new photography { id = 1, Nom = "Photo1", Path ="../"},
            new photography { id = 30, Nom = "Photo2", Path ="../"},
            new photography { id = 33, Nom = "Photo3", Path ="../"},
            new photography { id = 1, Nom = "Photo4", Path ="../"}
        };
    }
}