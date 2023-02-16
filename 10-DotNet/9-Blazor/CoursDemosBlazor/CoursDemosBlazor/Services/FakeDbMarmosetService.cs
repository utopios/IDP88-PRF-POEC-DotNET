using CoursDemosBlazor.Models;

namespace CoursDemosBlazor.Services
{
    public class FakeDbMarmosetService : IMarmosetService
    {
        public int LastId = 0;
        public List<Marmoset> Marmosets { get; set; } = new List<Marmoset>();
        public async Task<bool> Delete(int id)
        {
            var nbRemoved = Marmosets.RemoveAll(m => m.Id == id);
            Console.WriteLine(Marmosets.Count.ToString());
            return nbRemoved == 1;
        }

        public async Task<bool> Post(Marmoset marmoset)
        {
            var count = ++LastId;
            marmoset.Id = count + 1;
            Marmosets.Add(marmoset);
            Console.WriteLine(Marmosets.Count.ToString());
            return true;
        }
    }
}
