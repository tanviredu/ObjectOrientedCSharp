using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        // create the property for the save() method
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();
        // this valid property here will be overwritten
        // by the other class
        // using the polymorphism
        // but if you want to implement the Validate method
        // and overwrite them you need to add
        // the abstract keywork in the method too
        // only the abstract method can be overwritten
        // and abstract method has no implementation

        public abstract bool Validate();

        public enum EntityStateOption
        {
            Active,
            Deleted
        }

        // to find the object is created or deleted
        // we use the EntityStateOption to track if the 
        // object got deleted
        // the Entity state is a enum
        
        // add this enum EntityState to this class
        public EntityStateOption EntityState { get; set; }

        // these are the property of the save class
        // all the save class will be ingerited from this


    }
}
