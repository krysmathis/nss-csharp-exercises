namespace bangazon
{
    partial class Program
    {
        public interface ISecurityRequired {
            int minAccessLevelToEnter {get;set;}
            bool validAccess(int accessLevel);
        }
    }
}
