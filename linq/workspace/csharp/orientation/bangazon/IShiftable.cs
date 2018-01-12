namespace bangazon
{
    partial class Program
    {
        /*
                    Class for representing Human Resources department.

                    It is very important to note here that since HumanResources
                    inherits from the Department type, any object instance
                    is both of type HumanResources AND Department.

                    Remember, inheritance denotes an is-a relationship.
                        */
        public interface IShiftable {
            string Shift {get;set;}
        }
    }
}
