namespace bagoloot
{
    public class ToyAssigner
    {
        public void AssignToyToChild(Child child, string toy) {
            child.BagOLoot.Add(toy);
        }

        public void RemoveToyFromChild(Child child, string toy) {
            child.BagOLoot.Remove(toy);
        }
    }
}